/*
 * Created by SharpDevelop.
 * User: 송이네
 * Date: 2016-01-01
 * Time: 오후 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ImageListGenerator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		enum SourceType
		{
			Folder,
			Files
		};
		
		private List<String> FilenameList = new List<String>();
		private String CurrentWorkingDirectory = null;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/*
		 *
		<설명>
		Directory.GetFiles(String)
		 - 지정된 폴더에 있는 파일의 이름(경로 포함)을 반환한다.
		 - 하위 폴더는 검색하지 않는다.
		
		Directory.GetFiles(String, String)
		 - 지정된 폴더에서 지정된 검색 패턴과 일치하는 파일 이름(파일 경로 포함)을 반환한다.
		 - 하위폴더는 검색하지 않는다.
		
		Directory.GetFiles(String, String, SearchOption)
		 - 하위 폴더를 검색할지 여부를 나타내는 값을 사용하여 지정된 디렉터리에서 지정된 검색 패턴과 일치하는 파일 이름(파일 경로 포함)을 반환한다.
		
		
		<특이사항>
		 - 지정된 폴더에 있는 숨김 파일의 이름도 반환한다.
		
		
		<예제1>
		 - 지정된 확장자의 파일목록 가져오기
		 --------------------------------------------------------------------------------
		  string path = "PATH";
		  string searchPatterns = "*.txt|*.jpg";
		  stirng[] files = searchPatterns
		                        .Split('|')
		                        .SelectMany(searchPattern => Directory.GetFiles(path, searchPattern)).ToArray();
		
		<예제2: Directory.GetFiles()를 이용>
		--> FullFilepath가 전달된다.
		if (Directory.Exists(path))
		{
			foreach (string f in Directory.GetFiles(path))
		    {
				// 리스트 박스나 기타 다른 반복된 작업 수행
			}
		}
		
		<예제3: DirectoryInfo.GetFiles()를 이용>
		--> FileInfo는 세분화된 File 정보로 제공(FileName, Extension, DirectoryName 등)
		System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"d:\download");
		
		foreach(System.IO.FileInfo f in di.GetFiles())
		listBox1.Items.Add(f.Name + "  " + f.Extension)
		*/
		public bool GenerateFileListFromFolder()
		{
			FolderBrowserDialog folderDlg = new FolderBrowserDialog();
			folderDlg.Description = "Select Folder with files to enlist";		
			if(folderDlg.ShowDialog() != DialogResult.OK)
			{
				return false;
			}
			FilenameList.Clear();
			
			FileInfo[] fileInfoList = new DirectoryInfo(folderDlg.SelectedPath).GetFiles();
			foreach(FileInfo fileInfo in fileInfoList)
			{
				FilenameList.Add(fileInfo.Name);
			}
			CurrentWorkingDirectory = folderDlg.SelectedPath;
			return true;
		}
		
		public bool GenerateFileListFromFiles()
		{
			OpenFileDialog fileDlg = new OpenFileDialog();
			fileDlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
			fileDlg.Multiselect = true;
			fileDlg.Title = "Select Files to enlist";
			if(CurrentWorkingDirectory != null)
			{
				fileDlg.InitialDirectory = CurrentWorkingDirectory;
			}
			if (fileDlg.ShowDialog() != DialogResult.OK )
			{
				return false;
			}
			FilenameList.Clear();
			
			String[] fileNameList = fileDlg.SafeFileNames;	//exclude the directory path in filename string
			foreach(String fileName in fileNameList)
			{
				FilenameList.Add(fileName);
			}
			CurrentWorkingDirectory = fileDlg.FileNames[0];
			return true;
		}
		
		private void GenerateFileList(SourceType sourceType)
		{
			bool IsFileListImported = false;
			switch(sourceType)
			{
				case SourceType.Folder:
					IsFileListImported = GenerateFileListFromFolder();
					break;
				case SourceType.Files:
					IsFileListImported = GenerateFileListFromFiles();
					break;
				default:
					break;
			}
			
			if(IsFileListImported)
			{
				//String quotationMarkOpen, quotationMarkClose;
				//GetQuotationMark(out quotationMarkOpen, out quotationMarkClose);
				String[] filepathList = FilenameList.ToArray();
				for(int i = 0; i<filepathList.Length; i++)
				{
					filepathList[i] = this.textBox_Prefix.Text + filepathList[i] + this.textBox_Suffix.Text;
				}
				
				SaveOutputListFile(filepathList);
			}
		}
		
		private void SaveOutputListFile(String[] filepathList)
		{
			OpenFileDialog outputSaveFileDlg = new OpenFileDialog();
			if(CurrentWorkingDirectory != null)
			{
				outputSaveFileDlg.InitialDirectory = CurrentWorkingDirectory;
			}
			outputSaveFileDlg.DefaultExt = "txt";
			outputSaveFileDlg.CheckFileExists = false;	//new creation is allowed
			outputSaveFileDlg.CheckPathExists = false;	//new creation is allowed
			if(outputSaveFileDlg.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			
			File.WriteAllLines(outputSaveFileDlg.FileName, filepathList, Encoding.Default);
			//File.AppendAllText(outputSaveFileDlg.FileName, filepathList, Encoding.Default);
		}
		
		void ListFromFolderToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenerateFileList(SourceType.Folder);
		}
		
		void ListFromFilesToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenerateFileList(SourceType.Files);
		}
	}
}
