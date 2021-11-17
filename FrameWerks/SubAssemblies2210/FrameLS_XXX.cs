#region Copyright (c) 2019 WeaselWare Software
/************************************************************************************
'
' Copyright  2019 WeaselWare Software 
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
' Portions Copyright 2019 WeaselWare Software
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

namespace FrameWorks.Makes.System2210
{

    public class FrameLS_XXX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 3;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal overTravelAdd = 4.5m;
        const decimal overTravelRed = 6.9375m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.84375m;
        const decimal jambDimW = 1.46875m;
        const decimal sptJmbThick = 0.09375m;
        const decimal jambDimW2X = 2.0m * 1.46875m;
        const decimal jambInset = 0.375m;
        const decimal jambThickX2 = 2.0m * 0.09375m;
        const decimal notchHDPEadd = 4.0m;
        const decimal yTrackAdd = 2.5m;
        const decimal yTrAccess = 4.50m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_XXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2210-FrameLS_XXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region UniTopTrack

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackX__
            part = new Part(3406, "TopTrackX__", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + doorGap);
            part.PartGroupType = "UniTopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrack_X_
            part = new Part(3406, "TopTrack_X_", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + yTrackAdd);
            part.PartGroupType = "UniTopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrack__X
            part = new Part(3406, "TopTrack__X", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + yTrackAdd + doorGap);
            part.PartGroupType = "UniTopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedTTRubber -->> 
            part = new Part(3766, "ShapedTTRubber", this, 8, 0.0m);
            part.PartGroupType = "UniTopTrack";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumSplitJambInt -->> 
            part = new Part(6870, "AlumSplitJambInt", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumSplitJambExt -->> 
            part = new Part(6870, "AlumSplitJambExt", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumSplitJamb -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6870, "AlumSplitJamb", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadInt__X ^^
            part = new Part(4362, "SplitHeadInt__X", this, 1, m_subAssemblyWidth - sptJmbThick - jambDimW);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt_X_ ^^
            part = new Part(4362, "SplitHeadExt_X_", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - jambInset- stileOverLap + overTravelAdd );
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt__X ^^
            part = new Part(4362, "SplitHeadExt__X", this, 1, (trackHelper.DoorPanelWidth) - jambInset - overTravelRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal  
            part = new Part(4910, "QuadSeal", this, 2, 0.0m);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 4, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seal__X ^^
            part = new Part(3979, "Pile_LS_Seal__X", this, 1, m_subAssemblyWidth - jambDimW);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals_X_ ^^
            part = new Part(3979, "Pile_LS_Seals_X_", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - jambInset - stileOverLap + overTravelAdd);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals__X ^^
            part = new Part(3979, "Pile_LS_Seals__X", this, 1, (trackHelper.DoorPanelWidth) - jambInset - overTravelRed);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            string notchHDPE = string.Empty;
            decimal[] temp = new decimal[panelCount + 1];

            for (int i = 1; i < panelCount; i++)
            {

                switch (i)
                {
                    case 1:
                        {
                            temp[1] = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;
                            notchHDPE = temp[1].ToString() + ",";
                            break;
                        }
                    case 2:
                        {
                            temp[2] = (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[2].ToString() + ",";
                            break;
                        }
                    case 3:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }

                    case 4:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 4.0m) - stileOvrLpX3 + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }

                    default:
                        break;
                }

            }

            // notchHDPE 
            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, m_subAssemblyWidth - jambThickX2);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 8.625m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                part.PartGroupType = "HDPE_Head";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 2.875m;
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}