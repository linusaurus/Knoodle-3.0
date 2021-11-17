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

    public class FrameLS_PXX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 3;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambRed = 1.09375m;
        const decimal jambPocRed = 1.125m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW2X = 1.5m * 2.0m;
        const decimal jambInset = 0.375m;
        const decimal jambInset2X = 0.375m * 2.0m;
        const decimal spltHdRed = 6.9375m;
        const decimal faceMidoor = 2.4375m;
        const decimal faceXdoor = 4.50m;
        const decimal notchHDPEadd = 4.375m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEaddPoc = 4.5m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal trackAddPocket = 3.75m;
        const decimal trackAddOvTrav = 2.5m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_PXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2210-FrameLS_PXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambPocRed - jambRed, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region TopTrackUni

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPXX
            part = new Part(3406, "TopTrackPXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m - stileOverLap) - jambInset + trackAddPocket + doorGap);
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPX
            part = new Part(3406, "TopTrackPX", this, 1, (trackHelper.DoorPanelWidth * 2.0m - jambInset + trackAddPocket + trackAddOvTrav));
            part.PartGroupType = "TopTrackUni";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketGuides

            // PocketGuide
            part = new Part(5151, "WedgePocketGuide", this, 2, 0.0m);
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
            part = new Part(5216, "OTB_OX_PX", this, 1, 0.0m);
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

            //AlumSplitJambExt -->> 
            part = new Part(6870, "AlumSplitJambExt", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumSplitJambInt -->> 
            part = new Part(6870, "AlumSplitJambInt", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumPocketSplitJamb -->> 
            part = new Part(4357, "AlumPocketSplitJamb", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //AlumPocketSplitJamb -->> 
            part = new Part(4357, "AlumPocketSplitJamb", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadXX ^^
            part = new Part(4362, "SplitHeadXX", this, 1, m_subAssemblyWidth - jambPocRed - jambRed - jambInset2X);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExt_X ^^
            part = new Part(4362, "SplitHeadExt_X", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtX_ ^^
            part = new Part(4362, "SplitHeadExtX_", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PocketCloseOut

            //AlumBar
            part = new Part(2556, "AlumBar", this, 3, 0.0m);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.25m;
            part.PartWidth = 3.0m;
            part.PartLength = 5.0625m;
            part.PartLabel = "PXX";
            m_parts.Add(part);

            //Extira_Closeout
            part = new Part(3210, "Extira_Closeout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.75m;
            part.PartWidth = 5.3125m;
            part.PartLabel = "PXX";
            m_parts.Add(part);

            //Alum16gaCloseout
            part = new Part(3438, "Alum16gaCloseout", this, 1, m_subAssemblyHieght - faceMidoor);
            part.PartGroupType = "PocketCloseOut";
            part.PartThick = 0.063m;
            part.PartWidth = 3.0625m;
            part.PartLabel = "PXX";
            m_parts.Add(part);

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
            part = new Part(3979, "Pile_LS_Seals", this, 4, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealXXX ^^
            part = new Part(3979, "Pile_LS_SealXXX", this, 1, m_subAssemblyWidth - jambPocRed - jambRed - jambInset2X);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealExt__X ^^
            part = new Part(3979, "Pile_LS_SealExt__X", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealExt_X_  ^^
            part = new Part(3979, "Pile_LS_SealExt_X_", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_SealExtX__ ^^
            part = new Part(3979, "Pile_LS_SealExtX__", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
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
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX2 - jambInset) + headHDPEadd + headHDPEaddPoc);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 8.625m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb

            part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
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