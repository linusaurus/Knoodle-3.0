#region Copyright (c) 2016 WeaselWare Software
/************************************************************************************
'
' Copyright  2016 WeaselWare Software 
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
' Portions Copyright 2016 WeaselWare Software
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

    public class FrameLS_PXXXXP : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 4;
        const decimal faceCapX = 3.625m;
        const decimal facEndCap = 2.875m;
        const decimal facEndAcc = 2.9375m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW2X = 1.5m * 2.0m;
        const decimal jambInset = 0.375m;
        const decimal spltHdRed = 6.5275m;
        const decimal faceMidoor = 2.375m;
        const decimal faceXdoor = 4.1525m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal calkGap = 0.125m;
        const decimal trackAdd1 = 3.104625m;
        const decimal trackAdd2 = 6.28125m;


        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_PXXXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameLS_PXXXXP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackUni

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPXXXXP
            part = new Part(3406, "TopTrackPXXXXP", this, 1, m_subAssemblyWidth + trackHelper.DoorPanelWidth + trackAdd1);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPX_XP
            part = new Part(3406, "TopTrackPX_XP", this, 2, (trackHelper.DoorPanelWidth / 2.0m) * 2.0m + trackAdd2);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketGuides

            // PocketGuide
            part = new Part(5151, "WedgePocketGuide", this, 4, 0.0m);
            part.PartGroupType = "PocketGuides";
            part.PartLabel = "";
            part.PartThick = 0.405m;
            part.PartWidth = 1.4715m;
            part.PartLength = 5.0m;
            m_parts.Add(part);

            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_OX_PX
            part = new Part(5272, "OTB_Left", this, 1, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //OTB_XO_XP
            part = new Part(5216, "OTB_XO_XP", this, 1, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            part = new Part(5271, "OTB_Filler", this, 2, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambXXDoor -->> 
            part = new Part(4357, "AlumJambXXDoor", this, 4, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadXXXX ^^
            part = new Part(4362, "SplitHeadXXXX", this, 2, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtXXX ^^
            part = new Part(4362, "SplitHeadExtXXX", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtXX ^^
            part = new Part(4362, "SplitHeadExtXX", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtX ^^
            part = new Part(4362, "SplitHeadExtX", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHdCapX ^^
            part = new Part(4362, "SplitHdCapX", this, 2, faceCapX);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHdAccess ^^
            part = new Part(4362, "SplitHdAccess", this, 2, facEndAcc);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHdEndCap ^^
            part = new Part(4362, "SplitHdEndCap", this, 2, facEndCap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketCloseOut

            //////////////////////////////////////////////////////////////////////////////

            //AlumBar
            part = new Part(2556, "AlumBar", this, 6, 0.0m);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.25m;
            part.PartWidth = 3.0m;
            part.PartLength = 5.125m;
            part.PartLabel = "PXXXXP";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Extira_Closeout
            part = new Part(3210, "Extira_Closeout", this, 2, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.75m;
            part.PartWidth = 5.5m;
            part.PartLabel = "PXXXXP";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Alum16gaCloseout
            part = new Part(3438, "Alum16gaCloseout", this, 2, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.063m;
            part.PartWidth = 3.25m;
            part.PartLabel = "PXXXXP";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
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

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 2, m_subAssemblyWidth - jambDimW2X);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 2, faceCapX);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 2, facEndAcc);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 2, facEndCap);
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
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 4.0m) + jambReduce2X + doorGap2X + doorGap);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }


}