#region Copyright (c) 2021 WeaselWare Software
/************************************************************************************
'
' Copyright  2021 WeaselWare Software 
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
' Portions Copyright 2021 WeaselWare Software
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

    public class FrameNrwSldrOX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;

        const decimal stileOvrLp = 1.34375m;
        const decimal jambReduce = 0.84375m;
        const decimal jambReducePocket = 0.875m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambDimW = 1.5m;
        const decimal jambDimNew = 1.46875m;
        const decimal headHDPEadd2X = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameNrwSldrOX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-FrameNrwSldrOX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce - jambReducePocket - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region TopTrackUni

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top22mmTrackOX
            part = new Part(4447, "Top22mmTrackOX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOvrLp + doorGap2X);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);


            // Top22mmTrackO
            part = new Part(4447, "Top22mmTrackO", this, 1, (trackHelper.DoorPanelWidth ) + doorGap + 2.0m);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedRubber -->> 
            part = new Part(3766, "ShapedRubber", this, 8, 0.0m);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HEMOLELE

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Bronze_Hemo_OX
            part = new Part(4730, "Bronze_Hemo_OX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOvrLp + doorGap2X);
            part.PartGroupType = "HEMOLELE";
            part.PartLabel = "";
            m_parts.Add(part);

            //Bronze_Hemo_O
            part = new Part(4730, "Bronze_Hemo_O", this, 1, (trackHelper.DoorPanelWidth) + doorGap + jambReduce);
            part.PartGroupType = "HEMOLELE";
            part.PartLabel = "";
            m_parts.Add(part);


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //CRL_SS_CVR
            part = new Part(4691, "CRL_SS_CVR", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOvrLp + doorGap2X);
            part.PartGroupType = "HEMOLELE";
            part.PartLabel = "";
            m_parts.Add(part);


            //CRL_SS_CVR
            part = new Part(4691, "CRL_SS_CVR", this, 1, (trackHelper.DoorPanelWidth) + doorGap + jambReduce);
            part.PartGroupType = "HEMOLELE";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // SplitJamb
            for (int i = 0; i < 4; i++)
            {
                part = new Part(6870, "SplitJamb", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeads ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4362, "SplitHeads", this, 1, m_subAssemblyWidth - jambDimNew - jambDimNew);
                part.PartGroupType = "Frame";
                part.PartLabel = "Cut_1.875";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_VertSeals -->> 
            part = new Part(3979, "Pile_VertSeals", this, 4, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(3979, "Pile_Seals", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(3979, "Pile_Seals", this, 1, trackHelper.DoorPanelWidth);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(3979, "Pile_Seals", this, 2, trackHelper.DoorPanelWidth);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(3979, "Pile_Seals", this, 1, trackHelper.DoorPanelWidth);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount) - stileOvrLp + headHDPEadd2X);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 5.75m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            part = new Part(4400, "HDPE_Jamb", this, 2, m_subAssemblyHieght - calkGap - reducHDPE);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 5.75m;
            m_parts.Add(part);

            // HDPE_Jamb
            part = new Part(4400, "HDPE_Jamb", this, 2, m_subAssemblyHieght - calkGap - reducHDPE);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}