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

    public class FrameLS_OXBPXO : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 5;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal stileOvrLpX4 = 4.0m * 2.5625m;
        const decimal uTrackTopAdd = 2.5m;
        const decimal overTravBxADD = 4.5m;
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

        public FrameLS_OXBPXO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3090-FrameLS_OXBPXO";
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

            //TopTrackO___O
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3406, "TopTrackO___O", this, 1, (trackHelper.DoorPanelWidth) + doorGap + uTrackTopAdd);
                part.PartGroupType = "TopTrackUni-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //TopTrackOX__XO
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3406, "TopTrackOX__XO", this, 1, ((trackHelper.DoorPanelWidth) * 2.0m) + calkGap - stileOverLap + doorGap);
                part.PartGroupType = "TopTrackUni-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //TopTrack__BP__
            for (int i = 0; i < 1; i++)
            {

                part = new Part(3406, "TopTrack__BP__", this, 1, (trackHelper.DoorPanelWidth) + 2.0m * uTrackTopAdd);
                part.PartGroupType = "TopTrackUni-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            for (int i = 0; i < 4; i++)
            {

                part = new Part(3766, "ShapedYtrackRubber", this, 1, 0.0m);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTBO_BP__
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5425, "OTBO_BP__", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB__BP_O
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5426, "OTB__BP_O", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5271, "OTB_Filler", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //BrzJambFL -->> 
            for (int i = 0; i < 4; i++)
            {

                part = new Part(4363, "BrzJambFL", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //BrzJambLessH -->> 
            for (int i = 0; i < 4; i++)
            {

                part = new Part(4363, "BrzJambLessH", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // SpltHdIntOX__XO ^^
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4364, "SpltHdIntOX__XO", this, 1, ((trackHelper.DoorPanelWidth) * 2.0m) - stileOverLap - jambInset + headHDPEadd );
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // SpltHdExtO____O ^^
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4364, "SpltHdExtO____O", this, 1, (trackHelper.DoorPanelWidth) - jambInset + overTravBxADD);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // SpltHdExt_X__X_ ^^
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4364, "SpltHdExt_X__X_", this, 1, (trackHelper.DoorPanelWidth) - stileOvrLpX2 - 2.0m * overTravBxADD + doorGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // SpltHdExt__BP__ ^^
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4364, "SpltHdExt__BP__", this, 1, (trackHelper.DoorPanelWidth) + 2.0m * overTravBxADD);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region QuadSeal

            //////////////////////////////////////////////////////////////////////////////

            //QuadSeal
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4910, "QuadSeal", this, 1, 0.0m);
                part.PartGroupType = "QuadSeal";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            for (int i = 0; i < 8; i++)
            {

                part = new Part(4384, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Pile_LS_Seals-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Pile_T_Slot ^^
            for (int i = 0; i < 3; i++)
            {

                part = new Part(4384, "Pile_LS_Seals", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Pile_LS_Seals-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

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
            part = new Part(3442, "HDPE_Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 5.75m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////


            // HDPE_Fixed_O_Mount_Block
            for (int i = 0; i < 6; i++)
            {
                part = new Part(5670, "HDPE_MountBlock", this, 1, 0.0m);
                part.PartGroupType = "HDPE_DoorEdge-Parts";
                part.PartLabel = "DoorEdge";
                part.PartThick = 1.1642m;
                part.PartWidth = 1.5312m;
                part.PartLength = 4.0m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                part.PartGroupType = "HDPE_Head-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 2.875m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_HeadFiller ^^
            for (int i = 0; i < 2; i++)

            {
                part = new Part(4859, "HDPE_HeadFiller", this, 1, 0.0m);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = notchHDPE;
                part.PartThick = 0.75m;
                part.PartWidth = 2.75m;
                part.PartLength = 1.6875m;

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }


}