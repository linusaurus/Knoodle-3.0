#region Copyright (c) 2020 WeaselWare Software
/************************************************************************************
'
' Copyright  2020 WeaselWare Software 
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
' Portions Copyright 2020 WeaselWare Software
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

namespace FrameWorks.Makes.System2110
{

    public class Frame_NrwBstrd_XO : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;
        const decimal aluminumCrnBrk = 0.625m;
        const decimal stileOverLap = 1.9375m;
        const decimal stileOvrLpX2 = 2.0m * 1.9375m;
        const decimal stileOvrLpX3 = 3.0m * 1.9375m;
        const decimal stileCut = 0.46875m;
        const decimal splitHdOTB_add = 4.5m;
        const decimal splitHdOTB_Red = 5.375m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.84375m;
        const decimal jambDimW = 1.46875m;
        const decimal jambDimWX2 = 2.0m * 1.46875m;
        const decimal jambJustfyX2 = 2.0m * 0.03125m;
        const decimal jambInset = 0.375m;
        const decimal yTrack = 2.0m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEadd2X = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal reducHDPE2X = 2.0m * 0.75m;
        const decimal reducHDPEhead = 0.40625m;
        const decimal calkGap = 0.125m;
        const decimal jmbThkRed = 0.09375m;
        const decimal pileSlotRed = 1.1149m;

        //static int createID;

        #endregion

        #region Constructor

        public Frame_NrwBstrd_XO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-Frame_NrwBstrd_XO";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Frame_Xslider

            //////////////////////////////////////////////////////////////////////////////

            //SplitJambXDoorExt1 -->> 
            part = new Part(6870, "SplitJambXDoorExt", this, 1, m_subAssemblyHieght - jambJustfyX2 );
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            //SplitJambXDoorExt2 -->> 
            part = new Part(6870, "SplitJambXDoorExt", this, 1, m_subAssemblyHieght - jambJustfyX2);
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //SplitJambXDoorInt1 -->> 
            part = new Part(6870, "SplitJambXDoorInt", this, 1, m_subAssemblyHieght - jambJustfyX2);
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            //SplitJambXDoorInt2 -->> 
            part = new Part(6870, "SplitJambXDoorInt", this, 1, m_subAssemblyHieght - jambJustfyX2);
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHead1 ^^
            part = new Part(6870, "SplitHead", this, 1, m_subAssemblyWidth - jambDimWX2 - jambJustfyX2 );
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            // SplitHead2^^
            part = new Part(6870, "SplitHead", this, 1, m_subAssemblyWidth - jambDimWX2 - jambJustfyX2);
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitBottom1 ^^
            part = new Part(6870, "SplitBottom", this, 1, m_subAssemblyWidth - jambDimWX2 - jambJustfyX2 );
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            // SplitBottom2 ^^
            part = new Part(6870, "SplitBottom", this, 1, m_subAssemblyWidth - jambDimWX2 - jambJustfyX2);
            part.PartGroupType = "Frame_Xslider";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame_Fixed

            ////////////////////////////////////////////////////////////////////////////////

            //AlumJambL <--
            part = new Part(4342, "AlumJambs", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame_Fixed";
            part.PartLabel = "";
            m_parts.Add(part);

            //AlumJambR -->
            part = new Part(4342, "AlumJambs", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame_Fixed";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumHead ^^
            part = new Part(4342, "AlumHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame_Fixed";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AlumSill ||
            part = new Part(4342, "AlumSill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame_Fixed";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            /////////////////////////////////////////////////////////////////////////

            //AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 4, aluminumCrnBrk);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            //PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyBrackets";
            part.PartLabel = "1/4_20x.375";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_Seals

            //Pile_Seals -->> 
            for (int i = 0; i < 2; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth );

                part = new Part(3979, "Pile_Seals", this, 1, peri - pileSlotRed);
                part.PartGroupType = "Pile_Seals";
                part.PartLabel = "";
                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head ^^
            part = new Part(6980, "HDPE_Head", this, 1, m_subAssemblyWidth - doorGap );
            part.PartGroupType = "HDPE_Head";
            part.PartThick = 0.40625m;
            part.PartWidth = 2.625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_JambL <--
            part = new Part(6981, "HDPE_JambL", this, 1, m_subAssemblyHieght - reducHDPEhead - doorGap );
            part.PartGroupType = "HDPE_Head";
            part.PartThick = 0.75m;
            part.PartWidth = 2.625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_JambR -->
            part = new Part(6981, "HDPE_JambR", this, 1, m_subAssemblyHieght - reducHDPEhead - doorGap);
            part.PartGroupType = "HDPE_Head";
            part.PartThick = 0.75m;
            part.PartWidth = 2.625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Sill ^^
            part = new Part(6982, "HDPE_Sill", this, 1, m_subAssemblyWidth - reducHDPE2X - doorGap);
            part.PartGroupType = "HDPE_Head";
            part.PartThick = 0.73m;
            part.PartWidth = 2.625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}