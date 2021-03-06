﻿#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2014 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntitySpaces.Interfaces;
using FrameWorks;
using BinPackingCuttingStock;


namespace Weaselware.Knoodle
{
    public partial class Form1 : Form
    {

        BusinessObjects.UnitCollection incomingUnits;
        List<FrameWorks.Unit> buildUnits;
        BindingSource bs = new BindingSource();
        public FrameWorks.Project thisProject = new Project();

        BackgroundWorker worker;
        float sumOfItems;
        BusinessObjects.OutputCollection col;
        
     
        public Form1()
        {
            InitializeComponent();

            // Load the Parts into memory
            FrameWorks.SourceManager.SetConnectionString(@"Password=Kx09a32x;Persist Security Info=True;User ID=sa;
                                                          Initial Catalog=DSDB2;Data Source=DATASERVER");
            FrameWorks.LaborManager.SetConnectionString(@"Password=Kx09a32x;Persist Security Info=True;User ID=sa;
                                                          Initial Catalog=PARTDB;Data Source=DATASERVER");
            FrameWorks.LaborManager.Load();
            //Need to put better exception handling here and start logging the exception messages
            try
            {

                FrameWorks.SourceManager.Load(true);
                this.toolStripStatusLabel1.Text = "Parts Loaded : "
                    + FrameWorks.SourceManager.PartsSource.Count.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Connection to Parts Database Failed");
                this.toolStripStatusLabel1.Text = "Parts Not Loaded!";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = string.Empty ;
            
            if (Weaselware.Knoodle.Properties.Settings.Default.dataPath.Length > 0)
            {
                path = Weaselware.Knoodle.Properties.Settings.Default.dataPath.ToString();
                tssDataPath.Text = path;
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    Db.SetAccessConection(path);
                    this.Text = "Knoodle " + Application.ProductVersion.ToString() + " - " + Db.ProjectData().JobName.ToString();
                    LoadUnits();
                }
                else
                {
                    SetPath(path);
                    LoadUnits();
                    this.Text = "Knoodle " + Application.ProductVersion.ToString() + " - " + Db.ProjectData().JobName.ToString();
                }
            }
            else
            {
                SetPath(path);
                LoadUnits();
                this.Text = "Knoodle " + Application.ProductVersion.ToString() + " - " + Db.ProjectData().JobName.ToString();
            }
        
        }

        private void SetPath(string path)
        {
            openFileDialog1.Filter = "Access Database|*.mdb";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName.ToString();
                Db.SetAccessConection(path);
                Weaselware.Knoodle.Properties.Settings.Default.dataPath = path;
                Weaselware.Knoodle.Properties.Settings.Default.Save();
                tssDataPath.Text = path;
            }
        }
        /// <summary>
        ///  Build
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (incomingUnits != null)
            {
                if (incomingUnits.Count > 0)
                {
                   this.buildTree.Nodes.Clear();
                   // Populate the Object
                   buildUnits = Db.Build(incomingUnits);
                   Db.FillBuildTree(this.buildTree, buildUnits);

                }
            }
        }

        private void LoadUnits()
        {
            incomingUnits = Db.LoadUnitsFromDB();
            bs.Clear();
            bs.DataSource = incomingUnits;
            this.dataGridView1.DataSource = bs;
            this.Text ="Knoodle " + Application.ProductVersion.ToString() +" " + Db.ProjectData().JobName.ToString();
        }

        private void dataToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "setSourceToolStripMenuItem":
                    {
                        openFileDialog1.DefaultExt = "*.mdb";
                        openFileDialog1.Filter = "Access Database|*.mdb";

                        if (openFileDialog1.ShowDialog()== DialogResult.OK)
                        {
                            string path = openFileDialog1.FileName.ToString();
                            Db.SetAccessConection(path);
                            Weaselware.Knoodle.Properties.Settings.Default.dataPath = path;
                            tssDataPath.Text = path;
                            Db.SetAccessConection(path);
                            LoadUnits();

                        }
                        break;
                    }
                case "tsmprojectSettings":
                    {
                        ProjectEdit pEdit = new ProjectEdit();
                        pEdit.ShowDialog();
                        break;
                    }
                default:
                    break;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                    BusinessObjects.Unit  _unit = (BusinessObjects.Unit)bm.Current;

                    BusinessObjects.ComponentCollection subs = _unit.ComponentCollectionByUnitID;
                    this.dataGridView2.DataSource = subs;
                   
                }
                
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            this.incomingUnits.Save();
        }

        private void buildTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
                string sel = e.Node.Tag.GetType().BaseType.ToString() ;
               

                switch (sel)
                {
                    case "FrameWorks.SubAssemblyBase":
                        {
                            FrameWorks.SubAssemblyBase selectedPart = (FrameWorks.SubAssemblyBase)e.Node.Tag;
                            this.partPropertyGrid.SelectedObject = selectedPart;
                            break;
                        }
                    case "FrameWorks.AssemblyBase":
                        {
                            FrameWorks.AssemblyBase selectedPart = (FrameWorks.AssemblyBase)e.Node.Tag;
                            this.partPropertyGrid.SelectedObject = selectedPart;
                            break;
                        }
                    case "System.Object":
                        {
                          
                            FrameWorks.Part selectedPart = (FrameWorks.Part)e.Node.Tag;
                            this.partPropertyGrid.SelectedObject = selectedPart;
                            break;
                        }
                    case "FrameWorks.Part":
                        {

                            FrameWorks.LPart selectedPart = (FrameWorks.LPart)e.Node.Tag;
                            this.partPropertyGrid.SelectedObject = selectedPart;
                            break;
                        }
                   

                        
                    default:
                        break;
                }


        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //if (buildUnits != null &&  buildUnits.Count > 0)
            //{
               // this.dataGridView3.DataSource = Db.Write(buildUnits);
                BusinessObjects.OutputCollection colOutParts = new BusinessObjects.OutputCollection();
                BusinessObjects.OutputQuery qry = new BusinessObjects.OutputQuery();
                colOutParts.LoadAll();
                this.dataGridView3.DataSource = colOutParts;
                col = colOutParts;
            //}
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Value = 0;
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerAsync();
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.toolStripStatusLabel2.Text = "Write Completed!";
            this.toolStripProgressBar1.Value = 100;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Db.WriteParts(buildUnits, this.worker);
        }

        void ansynWrite_Completed(object sender, Db.WriteUnitsCompletedEventArgs e)
        {
            BusinessObjects.OutputCollection col = new BusinessObjects.OutputCollection();
            col = e.OutPut;
            this.dataGridView3.DataSource = col;
            MessageBox.Show("Done :" + e.OutPut.Count.ToString() + " Units Completed");
        }

        private void partPropertyGrid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ClassNameFinder classFinder = new ClassNameFinder();
                if (classFinder.ShowDialog() ==DialogResult.OK)
                {
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value = classFinder.SelectedClass;
                }
                
            }
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            if (buildUnits != null && buildUnits.Count > 0)
            {
                thisProject.JobName = "Test Project";
                thisProject.JobNumber = 1334;
                thisProject.VersionNumber = 1;
                this.thisProject.UnitsCollection.AddRange(buildUnits);

                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream(); // Stream
                bf.Serialize(ms, buildUnits); // "Save" object state
                saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;   
                    FrameWorks.Serializer s = new Serializer();
                    s.SerializeObject(path, thisProject);
                }

            }
        }

        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            Project p;
            FrameWorks.Serializer s = new Serializer();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                p = s.DeSerializeObject(path);
                buildTree.Nodes.Clear();
                Db.FillBuildTree(buildTree, p.UnitsCollection);
                this.buildUnits = p.UnitsCollection;

            }


        }

        private void buildTree_DoubleClick(object sender, EventArgs e)
        {

            if (buildTree.SelectedNode.Tag.GetType().BaseType.ToString() =="FrameWorks.SubAssemblyBase")
            {
                FrameWorks.SubAssemblyBase selected = (FrameWorks.SubAssemblyBase)buildTree.SelectedNode.Tag;
                PartEditor pedit = new PartEditor(selected);
                pedit.Show();
                
            }
           
        }

        private void bntClearModel_Click(object sender, EventArgs e)
        {
            buildUnits.Clear();
            this.buildTree.Nodes.Clear();
        }

        private void PartsStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// File Menu Actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string pick = e.ClickedItem.Name;
            switch (pick)
            {
                case "tsmsaveFile":
                    {
                        bs.EndEdit();
                        this.incomingUnits.Save();
                        break;
                    }
                case "tsmsaveAs":
                    {
                        break;
                    }
                case "tsmNewDataFile":
                    {
                        break;
                    }
                case "tsmExit":
                    {
                        if (((BusinessObjects.UnitCollection)bs.DataSource).IsDirty)
                        {
                            if (MessageBox.Show("Save Changes to Database?",
                                "Save",
                                MessageBoxButtons.OKCancel) == DialogResult.OK)
                            { 
                                bs.EndEdit();
                               this.incomingUnits.Save();
                               Application.Exit();
                            }
                            else { Application.Exit() ; }
                        }
                        else
                        {
                            Application.Exit();
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((BusinessObjects.UnitCollection)bs.DataSource).IsDirty)
            {
                if (MessageBox.Show("Save Changes to Database?",
                    "Save",MessageBoxButtons.OKCancel)== DialogResult.OK)
                    {
                    bs.EndEdit();
                    this.incomingUnits.Save();
                    Application.Exit();

                    }
                else { Application.Exit(); }
            }

        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            col = new BusinessObjects.OutputCollection();
           
            string filter = tbOptimizerFilter.Text.Trim();
            sumOfItems = float.Parse("0.0");
            int partID;

            if (int.TryParse(filter, out partID))
            {
                BusinessObjects.OutputQuery qry = new BusinessObjects.OutputQuery();
                qry.Select(qry.CutlistID,qry.Qnty, qry.Length, qry.SourceDescription,qry.PartIdentifier);
                qry.Where(qry.PartID == partID);
               
                col.Load(qry);
                this.dgOptimizerItems.DataSource = col;
            }
            foreach (BusinessObjects.Output o in col)
            {
                if (o.Length.HasValue) { sumOfItems += (float)o.Length.Value;  }
            }
            float totalFeet = sumOfItems / 12.0f ;
            lbSumofParts.Text = totalFeet.ToString() + " ft";
            //col = Db.OutParts();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            
             //public CuttingStock(List<Stock> theStocks, List<Item> theItems,
             //               float theTotalItemsSum, ToolStripLabel theTextBoxStatus,
             //               ToolStripProgressBar theToolStripProgressBar, CheckBox theExitGreedyNextFit)
            string materialName = string.Empty;
            if (!string.IsNullOrEmpty(tbOptimizerFilter.Text) )
            {
                int k = int.Parse(tbOptimizerFilter.Text.ToString());
               materialName = k.ToString() + " - " +  FrameWorks.SourceManager.PartsSource[k].MaterialDescription;
                
             }
            
            List<BinPackingCuttingStock.Item> theItems = new List<Item>();
            List<BinPackingCuttingStock.Stock> Stocks = new List<Stock>();
            BinPackingCuttingStock.Stock stock = new Stock();
            stock.ConsiderMaxPieces = false;
            stock.Cost = 20.00f;
            stock.MaxPieces = 0;
            stock.Size = float.Parse(tbStockLength.Text);
            stock.MaterialDescription = materialName;
            Stocks.Add(stock);

            if (col.HasData && col.Count > 0)
            {
                foreach (BusinessObjects.Output outp in col)
                {
                    BinPackingCuttingStock.Item i = new Item();
                    i.Pieces =(uint) outp.Qnty.Value;
                    i.Size = (float)outp.Length.Value;
                    i.BarCode = outp.PartIdentifier;
                    theItems.Add(i);
                }
            }
                   

            BinPackingCuttingStock.CuttingStock s = new CuttingStock(Stocks, theItems, sumOfItems, theTextBoxStatus, theToolStripProgressBar, theExitGreedyNextFit);
            s.Solve();
        }

        private void tabContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[6].Value = true;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[6].Value = false;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[6].Value.Equals(true))
                {
                    row.Cells[6].Value = false;
                }
                else { row.Cells[6].Value = true; }
            }
        }
    }
}


 
        
       


      


