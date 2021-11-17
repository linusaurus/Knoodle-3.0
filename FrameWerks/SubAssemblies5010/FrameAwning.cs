#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.System5010
{

    public class FrameAwning : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal gasketReduce = 1.250m;
        const decimal bronzeCrnBrk = 0.6250m;

        #endregion

        #region Constructor

        public FrameAwning()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameAwning";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Frame

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzOperWndLeft
            part = new Part(4526, "BrzOperWndLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzOperWndRight
            part = new Part(4526, "BrzOperWndRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzOperWndHead
            part = new Part(4526, "BrzOperWndHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzOperWndSill
            part = new Part(4526, "BrzOperWndSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodFrame

            ///////////////////////////////////////////////////////////////////////////////////////////////            

            // WoodOperLeft
            part = new Part(4333, "WoodOperLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "WoodFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodOperRight
            part = new Part(4333, "WoodOperRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "WoodFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodOperHead
            part = new Part(4333, "WoodOperHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "WoodFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////           

            // WoodOperSill
            part = new Part(4333, "WoodOperSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "WoodFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            part = new Part(4265, "BrzCnrBrkt", this, 4, bronzeCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AluCnrBrkt
            part = new Part(3206, "AluCnrBrkt", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            part = new Part(1545, "SocSetScrw.25_20", this, 32, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region OperHardware

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // OperatorEncoreAwning
            part = new Part(5096, "OperatorEncoreAwning", this, 1, 0.0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // LH_Encore®CoverHandle
            part = new Part(5140, "LH_Encore®CoverHandle", this, 1, 0.0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // OperatorBacker
            part = new Part(5253, "OperatorBacker", this, 1, 0.0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TruthMaxim24Lock
            part = new Part(4911, "TruthSeries24Lock", this, 2, 0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Keeper
            part = new Part(3516, "Keeper", this, 2, 0m);
            part.PartGroupType = "OperHardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //FrameSeal
            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);
            
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce); 
                
                part = new Part(2274, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}