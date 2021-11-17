#region Copyright (c) 2018 WeaselWare Software
/************************************************************************************
'
' Copyright  2018 WeaselWare Software 
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
' Portions Copyright 2018 WeaselWare Software
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

namespace FrameWorks.Makes.System3090
{

    public class FrameLS_PXOOOXP : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 5;
        const decimal screenRedPocX2 = 4.5m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal stileOvrLpX4 = 4.0m * 2.5625m;
        const decimal uTrackTopAdd = 2.0m;
        const decimal overTravBxADD = 4.0m;
        const decimal bronzePanelAdd = 3.5625m;
        const decimal spltHdRed1 = 6.5625m;
        const decimal spltHdAdd1 = 1.125m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal jambInset = 0.375m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal reducHDPE = 0.75m;
        const decimal headHDPEadd = 1.0m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_PXOOOXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3090-FrameLS_PXOOOXP";
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

            //TopTrackPXOOOXP
            part = new Part(3406, "TopTrackPXOOOXP", this, 1, m_subAssemblyWidth + ( 2.0m * trackHelper.DoorPanelWidth) - screenRedPocX2);
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrack_O_O_ ^^
            part = new Part(3406, "TopTrack_O_O_", this, 2, (trackHelper.DoorPanelWidth) + 2.0m * uTrackTopAdd );
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackBP_____PB
            part = new Part(3406, "TopTrackBP_____PB", this, 2, (trackHelper.DoorPanelWidth) + bronzePanelAdd);
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            part = new Part(3766, "ShapedYtrackRubber", this, 4, 0.0m);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_X___O
            part = new Part(5425, "OTB_X___O", this, 3, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //OTB_O___X
            part = new Part(5426, "OTB_O___X", this, 3, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            part = new Part(5271, "OTB_Filler", this, 6, 0.0m);
            part.PartGroupType = "Over_Travel";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //BrzJambPBX___XBP
            part = new Part(4363, "BrzJambPBX___XBP", this, 4, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //BrzJambP_______P 
            part = new Part(4363, "BrzJambP_______P", this, 2, m_subAssemblyHieght - reducHDPE - calkGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SpltHdIntX___X ^^
            part = new Part(4364, "SpltHdIntX___X", this, 1, m_subAssemblyWidth -  2.0m * jambDimW);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SpltHdExt1X_O3_X5 ^^
            part = new Part(4364, "SpltHdExt1X_O3_X5", this, 3, (trackHelper.DoorPanelWidth) - 2.0m * spltHdRed1);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // SpltHdExt_O2_04_ ^^
            part = new Part(4364, "SpltHdExt_O2_04_", this, 2, (trackHelper.DoorPanelWidth) + 2.0m * overTravBxADD);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region QuadSeal

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            part = new Part(4910, "QuadSeal", this, 6, 0.0m);
            part.PartGroupType = "QuadSeal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            part = new Part(3979, "Pile_LS_Seals", this, 6, m_subAssemblyHieght - calkGap);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_T_Slot ^^
            part = new Part(3979, "Pile_LS_Seals", this, 2, m_subAssemblyWidth +  2.0m * trackHelper.DoorPanelWidth - screenRedPocX2);
            part.PartGroupType = "Pile_LS_Seals-Parts";
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

            //////////////////////////////////////////////////////////////////////////////

            // notchHDPE 
            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, m_subAssemblyWidth + 2.0m * trackHelper.DoorPanelWidth - screenRedPocX2);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 5.75m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            part = new Part(4400, "HDPE_Jamb", this, 2, m_subAssemblyHieght - calkGap - reducHDPE);
            part.PartGroupType = "HDPE_Head-Parts";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_HeadFiller ^^
            part = new Part(4859, "HDPE_HeadFiller", this, 2, 0.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 2.75m;
            part.PartLength = 1.6875m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}