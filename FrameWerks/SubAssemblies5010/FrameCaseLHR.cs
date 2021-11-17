

#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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

    public class FrameCaseLHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal gasketReduce = 1.250m;
        const decimal bronzeCrnBrk = 0.6250m;

        #endregion

        #region Constructor

        public FrameCaseLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameCaseLHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region FrameAlumBrz

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AlumBrzLeft
            part = new Part(4526, "AlumBrzLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlumBrz";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AlumBrzRight
            part = new Part(4526, "AlumBrzRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAlumBrz";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AlumBrzHead
            part = new Part(4526, "AlumBrzHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlumBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // AlumBrzSill
            part = new Part(4526, "AlumBrzSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAlumBrz";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodFrame

            ///////////////////////////////////////////////////////////////////////////////////////////////            

            // WoodOperWndLeft
            part = new Part(4333, "WoodOperWndLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "WoodFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // WoodOperWndRight
            part = new Part(4333, "WoodOperWndRight", this, 1, m_subAssemblyHieght);
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

            // WoodOperWndSill
            part = new Part(4333, "WoodOperWndSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "WoodFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            ///////////////////////////////////////////////////////////////////////////////////////////////            

            // BrzCnrBrkt
            part = new Part(4853, "BrzCnrBrkt", this, 4, bronzeCrnBrk);
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

            #region Hardware

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //LockLogic
            //int hardwarecount = 1;
            //if (m_subAssemblyHieght < 49.749m)
            //{
            //    hardwarecount = 1;
            //}
            // else
            //{
            //    hardwarecount = 2;
            //}

            // Lock
            //part = new Part(1709, "Lock", this, hardwarecount, 0m);
            // part.PartGroupType = "Hardware";
            //part.PartLabel = "";
            //m_parts.Add(part);

            //Get the size of the tiebar partNo--
            //decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);

            //check is sash even requires a tiebar
            //if (tieBarLength != 0)
            //{
            // Tie Bars
            //    part = new Part(3625, "Tie Bars", this, 1, tieBarLength);
            //   part.PartGroupType = "Hardware";
            //    part.PartLabel = "";
            //    m_parts.Add(part);
            //}


            ///////////////////////////////////////////////////////////////////////////////////////////////

            // SupportBlockL
            part = new Part(2995, "SupportBlockL", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
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