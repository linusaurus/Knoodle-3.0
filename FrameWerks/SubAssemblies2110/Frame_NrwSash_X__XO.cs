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

    public class Frame_NrwSash_X__XO : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 3;

        const decimal stileOverLap = 1.9375m;
        const decimal stileOvrLpX2 = 2.0m * 1.9375m;
        const decimal stileOvrLpX3 = 3.0m * 1.9375m;
        const decimal stileCut = 0.46875m;
        const decimal stileCut2X = 0.46875m * 2.0m;
        const decimal splitHdOTB_add = 4.50m;
        const decimal splitHdOTB_Red = 5.3750m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal jambInset = 0.375m;
        const decimal yTrackAdd = 2.5m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEaddX2 = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public Frame_NrwSash_X__XO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-Frame_NrwSash_X__XO";
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

            //Top22mmTrackX>_O
            part = new Part(4447, "Top22mmTrackX>_O", this, 1, (trackHelper.DoorPanelWidth * 3.0m - stileOvrLpX2) + doorGap2X);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top22mmTrack_<X_
            part = new Part(4447, "Top22mmTrack_<X_", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileOverLap - stileCut + yTrackAdd);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            part = new Part(3766, "ShapedYtrackRubber", this, 4, 0.0m);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_OX_PX
            part = new Part(6876, "OTB_OX_PX", this, 1, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            part = new Part(6877, "OTB_Filler", this, 1, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //SplitJambX><XO -->> 
            part = new Part(6870, "SplitJambX><XO", this, 3, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
         
            //SplitJambIntX><XO -->> 
            part = new Part(6870, "SplitJambIntX><XO", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtX><XO ^^
            part = new Part(4362, "SplitHeadExtX><XO", this, 1, m_subAssemblyWidth - 2.0m * jambDimW);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "Cut_1.875";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadIntX<>X_ ^^
            part = new Part(4362, "SplitHeadIntX<>X_", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileOverLap - stileCut + splitHdOTB_add);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "Cut_1.875";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadInt_><_O
            part = new Part(4362, "SplitHeadInt_><_O", this, 1, trackHelper.DoorPanelWidth - stileCut - jambInset - splitHdOTB_Red);
            part.PartGroupType = "Frame-Parts";
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

            //Pile_Seals -->> 
            part = new Part(3979, "Pile_Seals", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_Seals -->> 
            part = new Part(3979, "Pile_Seals", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_SealsX><XO ^^
            part = new Part(3979, "Pile_SealsX><XO", this, 1, m_subAssemblyWidth - 2.0m * jambDimW);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_SealsX<>X_ ^^
            part = new Part(3979, "Pile_SealsX<>X_", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileOverLap - stileCut + splitHdOTB_add);
            part.PartGroupType = "Pile_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_Seals_><_O
            part = new Part(3979, "Pile_Seals_><_O", this, 1, trackHelper.DoorPanelWidth - stileCut - jambInset - splitHdOTB_Red);
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
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount - stileOvrLpX2 + headHDPEaddX2));
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 5.75m;

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