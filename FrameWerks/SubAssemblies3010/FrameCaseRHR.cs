﻿#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.System3010
{

    public class FrameCaseRHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.64m;
        const decimal gasketReduce = 1.250m;



        #endregion

        #region Constructor

        public FrameCaseRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-FrameCaseRHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Frame



            // JmbBrzL <<-- 

            part = new Part(4303, "JmbBrzL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);

            m_parts.Add(part);


            // JmbBrzR -->> 

            part = new Part(4303, "JmbBrzR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



            // HeadBrz ^^

            part = new Part(4303, "HeadBrz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:3627";

            m_parts.Add(part);


            // SillBrz ||

            part = new Part(4303, "SillBrz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:3627";

            m_parts.Add(part);



            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            for (int i = 0; i < 32; i++)
            {
                part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware-Parts



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
            // part.PartGroupType = "Hardware-Parts";
            //part.PartLabel = "";

            //m_parts.Add(part);


            //Get the size of the tiebar partNo--
            //decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);

            //check is sash even requires a tiebar
            //if (tieBarLength != 0)
            //{
            // Tie Bars
            //    part = new Part(3625, "Tie Bars", this, 1, tieBarLength);
            //   part.PartGroupType = "Hardware-Parts";
            //    part.PartLabel = "";

            //    m_parts.Add(part);
            //}



            // SupportBlockL
            part = new Part(2995, "SupportBlockL", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);




            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //FrameSeal
                part = new Part(2274, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion


        }



        #endregion


    }
}