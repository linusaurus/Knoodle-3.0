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

namespace FrameWorks.Makes.System2110
{

    public class Frame_NrwSash_OXX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 3;
        const decimal stileOverLap = 1.9375m;
        const decimal stileOvrLpX2 = 2.0m * 1.9375m;
        const decimal stileOvrLpX3 = 3.0m * 1.9375m;
        const decimal stileCut = 0.46875m;
        const decimal stileCut2X = 0.46875m * 2.0m;
        const decimal splitHdOTB_add = 4.5m;
        const decimal splitHdOTB_Red = 5.375m;
        const decimal splitMidDrED = 0.875m;
        const decimal frameReduce = 1.125m;
        const decimal frameRed2X = 1.125m * 2.0m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.84375m;
        const decimal jambDimW = 1.46875m;
        const decimal jambDimW2X = 1.5m * 2.0m;
        const decimal jambInset = 0.375m;
        const decimal yTrack = 2.5m;
        const decimal yTrAccess = 2.5m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEadd2X = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal jmbThkRed = 0.09375m;

        //static int createID;

        #endregion

        #region Constructor

        public Frame_NrwSash_OXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-Frame_NrwSash_OXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region TopTrackY

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top22mmTrack__X
            part = new Part(4447, "Top22mmTrack__X", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + doorGap);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top22mmTrack_X_
            part = new Part(4447, "Top22mmTrack_X_", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap - stileCut + yTrAccess);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top22mmTrackO__
            part = new Part(4447, "Top22mmTrackO__", this, 1, (trackHelper.DoorPanelWidth) - stileCut + doorGap + yTrAccess);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ShapedYtrackRubber -->> 
            part = new Part(3766, "ShapedYtrackRubber", this, 4, 0.0m);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_OX_PX
            part = new Part(6876, "OTB_OX_PX", this, 2, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            part = new Part(6877, "OTB_Filler", this, 2, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // SplitJambXDoor1 -->> 
            part = new Part(6870, "SplitJambXDoor1", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            // SplitJambXDoor2 -->> 
            part = new Part(6870, "SplitJambXDoor2", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitJambIntODoor -->> 
            part = new Part(6870, "SplitJambIntODoor", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitJambExtODoor -->> 
            part = new Part(6870, "SplitJambExtODoor", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadInt ^^
            part = new Part(4362, "SplitHeadInt", this, 1, m_subAssemblyWidth - jambDimW - jmbThkRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "Cut_1.875";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtO ^^
            part = new Part(4362, "SplitHeadExtO", this, 1, trackHelper.DoorPanelWidth - stileCut - jambInset + splitHdOTB_add);
            part.PartGroupType = "Frame";
            part.PartLabel = "Cut_1.875";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtXX ^^
            part = new Part(4362, "SplitHeadExtXX", this, 1, trackHelper.DoorPanelWidth - stileCut2X - splitMidDrED);
            part.PartGroupType = "Frame";
            part.PartLabel = "Cut_1.875";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtX ^^
            part = new Part(4362, "SplitHeadExtX", this, 1, trackHelper.DoorPanelWidth - stileCut - jambInset - splitHdOTB_Red);
            part.PartGroupType = "Frame";
            part.PartLabel = "Cut_1.875";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_Seals

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            part = new Part(4910, "QuadSeal", this, 2, 0.0m);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_VertSeals -->> 
            part = new Part(3979, "Pile_VertSeals", this, 4, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(3979, "Pile_Seals", this, 1, m_subAssemblyWidth - jambDimW - jmbThkRed);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(3979, "Pile_Seals", this, 1, trackHelper.DoorPanelWidth - stileCut - jambInset + splitHdOTB_add);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^            
            part = new Part(3979, "Pile_Seals", this, 1, trackHelper.DoorPanelWidth - stileCut2X - splitMidDrED);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_Seals ^^
            part = new Part(3979, "Pile_Seals", this, 1, trackHelper.DoorPanelWidth - stileCut - jambInset - splitHdOTB_Red);
            part.PartGroupType = "Pile_Seals";
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
                            temp[2] = (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap - stileCut + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[2].ToString() + ",";
                            break;
                        }
                    case 3:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 - stileCut + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }

                    case 4:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 4.0m) - stileOvrLpX3 - stileCut + headHDPEadd + notchHDPEadd;
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
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount) - stileOvrLpX2 + headHDPEadd2X);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 11.5m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Mntg_Block_O
            part = new Part(6865, "Mntg_Block_O", this, 3, 0.0m);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.7125m;
            part.PartWidth = 1.59375m;
            part.PartLength = 5.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

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