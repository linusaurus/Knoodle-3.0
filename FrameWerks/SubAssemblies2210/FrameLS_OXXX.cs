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

    public class FrameLS_OXXX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 4;
        const decimal AglORed = 3.2923m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.84375m;
        const decimal splitHdRedP1 = 5.84375m;
        const decimal splitHdRedP2_3 = 2.4375m;
        const decimal splitHdAddP_O = 4.125m;
        const decimal jambDimW = 1.46875m;
        const decimal jambInset = 0.375m;
        const decimal jambLegT = 0.09375m;
        const decimal yTrack = 2.0m;
        const decimal yTrAccess = 4.5m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEadd2X = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_OXXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2210-FrameLS_OXXX";
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

            // TopTrackO
            part = new Part(3406, "TopTrackO", this, 1, trackHelper.DoorPanelWidth + doorGap + yTrAccess - yTrack);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackX
            part = new Part(3406, "TopTrackX", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileOverLap  + yTrAccess - yTrack);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackXX
            part = new Part(3406, "TopTrackXX", this, 1, trackHelper.DoorPanelWidth * 3.0m - stileOvrLpX2  + yTrAccess - yTrack);
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackXXX
            part = new Part(3406, "TopTrackXXX", this, 1, trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX3 + doorGap );
            part.PartGroupType = "TopTrackY";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedTTRubber -->> 
            for (int i = 0; i < 6; i++)
            {            
                part = new Part(3766, "ShapedTTRubber", this, 1, 0.0m);
                part.PartGroupType = "TopTrackY";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_OX_PX
            for (int i = 0; i < 3; i++)
            {
                part = new Part(5216, "OTB_OX_PX", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            for (int i = 0; i < 3; i++)
            {
                part = new Part(5271, "OTB_Filler", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumSplitJambOInt -->> 
            part = new Part(6870, "AlumSplitJambOInt", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumSplitJambOExt -->> 
            part = new Part(6870, "AlumSplitJambOExt", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //AlumSplitJambX -->> 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(6870, "AlumSplitJambX", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadInt ^^
            part = new Part(4362, "SplitHeadInt", this, 1, m_subAssemblyWidth - jambDimW - jambLegT);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtX ^^
            part = new Part(4362, "SplitHeadExtX", this, 1, trackHelper.DoorPanelWidth - jambDimW - splitHdRedP1);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtXX ^^
            part = new Part(4362, "SplitHeadExtXX", this, 1, trackHelper.DoorPanelWidth - splitHdRedP2_3);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtXXX ^^
            part = new Part(4362, "SplitHeadExtXXX", this, 1, trackHelper.DoorPanelWidth - splitHdRedP2_3);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtO ^^
            part = new Part(4362, "SplitHeadExtO", this, 1, trackHelper.DoorPanelWidth + splitHdAddP_O);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            part = new Part(4910, "QuadSeal", this, 3, 0.0m);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 2, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimW - jambInset);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimW + doorGap - jambInset);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - jambDimW + doorGap - jambInset);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - jambDimW + doorGap - jambInset);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) - AglORed - jambInset);
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

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount) - stileOvrLpX3 + headHDPEadd2X);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 11.5m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;
            m_parts.Add(part);

            // HDPE_Jamb
            part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Mntg_Block_O
            part = new Part(7383, "Mntg_Block_O", this, 3, 0.0m);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 1.1642m;
            part.PartWidth = 1.5582m;
            part.PartLength = 5.0m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}