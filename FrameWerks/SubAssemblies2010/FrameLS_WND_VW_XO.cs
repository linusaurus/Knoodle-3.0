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

namespace FrameWorks.Makes.System2010
{

    public class FrameLS_WND_VW_XO : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;
        const decimal FaciaCap10 = 2.9375m;
        const decimal fastRacRed2X = 0.3125m * 2.0m;
        const decimal jambDimW = 1.6875m;
        const decimal jambDimWX2 = 2.0m * 1.6875m;
        const decimal headCentRed = 2.0111m;
        const decimal jambLockDel = 1.0625m;
        const decimal jambBumpDel = 1.6875m;
        const decimal headCvrJmbRed = 1.5738m;
        const decimal headCvrMidRed = 2.1361m;
        const decimal sillReduceInt = 2.875m;
        const decimal sillReduceExt = 1.75m;
        const decimal widthRedHDPE = 0.625m;
        const decimal yTrAccess = 3.78125m;
        const decimal reducHDPEsill = 2.375m;
        const decimal reducHDPE = 0.75m;
        const decimal calkJoint = 0.125m;



        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_WND_VW_XO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameLS_WND_VW_XO";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Track

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackX
            part = new Part(3406, "TopTrackX", this, 1, m_subAssemblyWidth - jambLockDel - jambBumpDel);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // TopTrackO
            part = new Part(3406, "TopTrackO", this, 1, (m_subAssemblyWidth / 2.0m) + yTrAccess - jambLockDel);
            part.PartGroupType = "Track";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            part = new Part(3766, "ShapedYtrackRubber", this, 2, 0.0m);
            part.PartGroupType = "Track";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //SS_Blade
            part = new Part(3444, "SS_Blade", this, 1, m_subAssemblyWidth - fastRacRed2X);
            part.PartGroupType = "Track";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AngleStand_O
            part = new Part(267, "AngleStand_O", this, 1, (m_subAssemblyWidth / 2.0m) + 0.21875m);
            part.PartGroupType = "Track";
            part.PartLabel = "";
            part.PartThick = 0.375m;
            part.PartWidth = 0.75m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //HDPE_Stand_O
            part = new Part(3528, "HDPE_Stand_LS_O", this, 1, (m_subAssemblyWidth / 2.0m) + 0.21875m);
            part.PartGroupType = "Track";
            part.PartLabel = "";
            part.PartThick = 0.8709m;
            part.PartWidth = 0.9142m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_XO_XP
            part = new Part(5272, "OTB_XO_XP", this, 1, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            part = new Part(5271, "OTB_Filler", this, 1, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambOWndExt -->> 
            part = new Part(4362, "AlumJambOWndExt", this, 2, m_subAssemblyHieght - sillReduceExt - calkJoint);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambXWndCenter -->> 
            part = new Part(4362, "AlumJambXWndCenter", this, 2, m_subAssemblyHieght - sillReduceExt - calkJoint - reducHDPE);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambXWndInt -->> 
            part = new Part(4362, "AlumJambXWndInt", this, 2, m_subAssemblyHieght - sillReduceInt);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadWndInt ^^
            part = new Part(4362, "SplitHeadWndInt", this, 1, m_subAssemblyWidth - jambDimWX2);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadWndExtX ^^
            part = new Part(4362, "SplitHeadWndExtX", this, 1, (m_subAssemblyWidth / 2.0m) - jambDimW - headCentRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadWndExtO ^^
            part = new Part(4362, "SplitHeadWndExtO", this, 1, m_subAssemblyWidth - jambDimWX2);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHdCap10 ^^
            part = new Part(4362, "SplitHdCap10", this, 1, FaciaCap10);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AglOWndJambCover ^^
            part = new Part(4490, "AglOWndJambCover", this, 1, m_subAssemblyHieght - reducHDPE - sillReduceExt - calkJoint);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // AglOWndHeadCover ^^
            part = new Part(4490, "AglOWndHeadCover", this, 1, (m_subAssemblyWidth / 2.0m) - headCvrJmbRed - headCvrMidRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SillAngleWnd_VW_Ext ^^
            part = new Part(4468, "SillAngleWnd_VW_Ext", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            part.PartThick = 1.75m;
            part.PartWidth = 4.125m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SillAngleWndInt ^^
            part = new Part(4469, "SillAngleWndInt", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            part.PartThick = 0.50m;
            part.PartWidth = 1.25m;
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            part = new Part(4910, "QuadSeal", this, 1, 0.0m);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 2, m_subAssemblyHieght - sillReduceExt - calkJoint);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 2, m_subAssemblyHieght - sillReduceExt - calkJoint - reducHDPE);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 2, m_subAssemblyHieght - sillReduceInt);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimWX2);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, (m_subAssemblyWidth / 2.0m) - jambDimW - headCentRed);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";        
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimWX2);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, FaciaCap10);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, m_subAssemblyWidth - widthRedHDPE);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 5.75m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            part = new Part(4400, "HDPE_Jamb", this, 2, m_subAssemblyHieght - reducHDPE - reducHDPEsill);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Sill
            part = new Part(4400, "HDPE_Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 1.5m;
            part.PartWidth = 5.5m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }


}