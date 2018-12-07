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
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.SubAssembliesFASTrack
{
    class FTPXXXXXXP : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 6;
        const bool biparting = true;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX4 = 4.0m * 2.5625m;
        const decimal endCapAdd = 0.125m;
        const decimal endCapAddx2 = 2.0m *0.125m;
        const decimal centerGap = 0.25m;
        const decimal centGapHlf = 0.25m / 2.0m;
        
        
        

        #endregion

        #region Math Functions



        #endregion

        #region Constructor

        public FTPXXXXXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTPXXXXXXP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            BridgeGenie bridgeGenie = new BridgeGenie(2.25m);
            TrackHelper trackHelper;

            if (biparting)
            {
                 trackHelper = new TrackHelper(panelCount/2,( m_subAssemblyWidth / 2) - centGapHlf, 0);
                
            }
            else
            {
                trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - stileOverLap, 0);
              
            }


            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            string handing;


            #region BladeSS
            if (biparting)
            {
                //Blade_____XP
                for(int i = 0; i < 2; i++)
                {
                    if (i == 0) { handing = "Blade_____XP-Right"; } else {handing = "BladeXP____Left"; }
                    part = new Part(3444, handing, this, 1, trackHelper.DoorPanelWidth * 2.0m + endCapAdd);
                    part.PartGroupType = "BladeSS-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
            }
            else
            {
                //BladePX_____

                part = new Part(3444, "BladePX_____", this, 1, trackHelper.DoorPanelWidth * 2.0m + endCapAdd);
                part.PartGroupType = "BladeSS-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (biparting)
            {
                // BladePXX____
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0) { handing = "BladePXX____Right"; } else { handing = "Blade____XXP-Left"; }
                    part = new Part(3444, handing, this, 1, trackHelper.DoorPanelWidth * 3.0m - stileOverLap + endCapAdd);
                    part.PartGroupType = "BladeSS-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
            }
            else
            {
                part = new Part(3444, "Blade____XXP", this, 1, trackHelper.DoorPanelWidth * 3.0m - stileOverLap + endCapAdd);
                part.PartGroupType = "BladeSS-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            // BladePXXXXXXP
            if (biparting)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (i == 0) { handing = "Right"; } else { handing = "Left"; }
                    part = new Part(3444, "BladePXXXXXXP"+ handing, this, 1, trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX4 + endCapAdd + centGapHlf);
                    part.PartGroupType = "BladeSS-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
            }
            else
            {
           
                    part = new Part(3444, "BladePXXXXXXP", this, 1, trackHelper.DoorPanelWidth * 8.0m - stileOvrLpX4 + endCapAddx2 + centerGap);
                    part.PartGroupType = "BladeSS-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BridgeAssemble

            //BridgeAssemble
            // Biparting----------------->>
            if (biparting)
            {

            
                for (int i = 1; i < panelCount/2 + 1; i++)
                {
                    //Bridge

                    if (i > 1)
                    {

                        decimal waste = decimal.Zero;
                        for (int j = 1; j < (trackHelper.BridgeCount * 2) + 1; j++)
                        {

                            part = new Part(3445, "Bridge--1", this, 1, bridgeGenie.result[i - 1]);
                            part.PartGroupType = "BridgeAssemble-Parts";
                            part.PartLabel = "";
                            m_parts.Add(part);
                            waste += 0.125m;
                        }
                        part = new Part(3445, "Cutting Waste", this, 1, waste);
                        m_parts.Add(part);

                       

                    }
                    // First door logic ---------------------
                    else
                    {
                        decimal waste = decimal.Zero;
                        for (int j = 1; j < (trackHelper.BridgeCount * 2) + 1; j++)
                        {
                            part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                            part.PartGroupType = "BridgeAssemble-Parts";
                            part.PartLabel = "";

                            m_parts.Add(part);
                            waste += 0.125m;
                        }
                        part = new Part(3445, "Cutting Waste", this, 1, waste);
                        m_parts.Add(part);
                    }


                    //BridgeClips

                    if (i > 1)
                    {

                        part = new Part(3446, "BridgeClips", this, (trackHelper.BridgeCount * 4)+ 1, 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);

                    }

                    else
                    {

                        part = new Part(3446, "BridgeClips", this, (trackHelper.BridgeCount * 4) + 1, 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);

                    }

                //TrackClips
                           
                    part = new Part(3447, "TrackClips", this, (trackHelper.BridgeCount * i * 2)*2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);



                    part = new Part(3449, "CapScrews", this,( trackHelper.BridgeCount * i * 2) * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);



                    //FlangeNuts

                    if (i > 1)
                    {
                        part = new Part(3450, "FlangeNuts", this, (trackHelper.BridgeCount * 4) * 2, 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);

                    }
                    else
                    {
                        part = new Part(3450, "FlangeNuts", this,( trackHelper.BridgeCount * 4) * 2, 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);
                    }


                    //NutPlateConnector

                    if (i > 1 && i != panelCount/2)
                    {
                        // your the second door but NOT second to last
                        if (i >= 2 && i < (panelCount - 1))
                        {
                            part = new Part(3448, "NutPlateConnector", this, (trackHelper.BridgeCount * (panelCount - 2)) * 2, 0.0m);
                            part.PartGroupType = "BridgeAssemble-Parts";
                            part.PartLabel = "";

                            m_parts.Add(part);
                        }
                        // your the second door but ARE second to last
                        else
                        {
                            part = new Part(3448, "NutPlateConnector", this, (trackHelper.BridgeCount * (panelCount - 2)) * 2, 0.0m);
                            part.PartGroupType = "BridgeAssemble-Parts";
                            part.PartLabel = "";

                            m_parts.Add(part);

                        }



                    }// end of loop
                }
            }

            #region Standard
            if (!biparting)
            {
          
            for (int i = 1; i < panelCount + 1; i++)
            {
                //Bridge

                if (i > 1)
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    {
                        part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";
                        m_parts.Add(part);
                        waste += 0.125m;
                    }
                    part = new Part(3445, "Cutting Waste", this, 1, waste);
                    m_parts.Add(part);
                }

                else
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    {
                        part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);
                        waste += 0.125m;
                    }
                    part = new Part(3445, "Cutting Waste", this, 1, waste);
                    m_parts.Add(part);
                }


                //BridgeClips

                if (i > 1)
                {

                    part = new Part(3446, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                else
                {

                    part = new Part(3446, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }


                //TrackBolts

                //if (i > 1)
                //{
                //part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                //part.PartGroupType = "BridgeAssemble-Parts";
                //part.PartLabel = "";

                //m_parts.Add(part);
                //}
                //else
                //{
                //part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                //part.PartGroupType = "BridgeAssemble-Parts";
                //part.PartLabel = "";

                //m_parts.Add(part);
                //}



                //TrackClips

                part = new Part(3447, "TrackClips", this, trackHelper.BridgeCount * i * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                part = new Part(3449, "CapScrews", this, trackHelper.BridgeCount * i * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                //FlangeNuts

                if (i > 1)
                {
                    part = new Part(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
                else
                {
                    part = new Part(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);
                }


                //NutPlateConnector

                if (i > 1 && i != panelCount)
                {
                    // your the second door but NOT second to last
                    if (i >= 2 && i < (panelCount - 1))
                    {
                        part = new Part(3448, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);
                    }
                    // your the second door but ARE second to last
                    else
                    {
                        part = new Part(3448, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);

                    }



                    }// end of loop

                }
            }
            #endregion
            #endregion

            #region PVC_Pocket_Drain

            // PVC_Pocket_Drain

            for (int i = 0; i < 2; i++)
            {
                part = new Part(5628, "PVC_Pocket_Drain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Pocket_Drain-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            #endregion

            #region PocBrdgAssY

            //PocBrdgAssY

            //Bridge
            if (biparting)
            {
                
                for (int i = 1; i < panelCount / 2 + 1; i++)

                { 


                    decimal CutWaste = decimal.Zero;
            for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
            {
                part = new Part(3445, "BridgePoc", this, 1, bridgeGenie.result [(panelCount /2  ) - 1] );
                part.PartGroupType = "PocBrdgAssY-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
                CutWaste += 0.125m;
            }

            part = new Part(3445, "CutPocWaste", this, 1, CutWaste);
            m_parts.Add(part);


            //BridgeClips

            part = new Part(3446, "BridgeClipsPoc", this, trackHelper.BridgeCount * ((panelCount / 2) - 2), 0.0m);
            part.PartGroupType = "PocBrdgAssY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //TrackClips
            part = new Part(3447, "TrackClipsPoc", this, (trackHelper.BridgeCount * (panelCount / 2) * 2), 0.0m);
            part.PartGroupType = "PocBrdgAssY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //NutPlateConnector

            // your the second door but NOT second to last

            part = new Part(3448, "NutPlateConPoc", this, trackHelper.BridgeCount * ((panelCount / 2) - 2), 0.0m);
            part.PartGroupType = "PocBrdgAssY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //CapScrews

            part = new Part(3449, "CapScrewsPoc", this, trackHelper.BridgeCount * (panelCount / 2) * 2, 0.0m);
            part.PartGroupType = "PocBrdgAssY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //FlangeNuts
            part = new Part(3450, "FlangeNutsPoc", this, trackHelper.BridgeCount * 8, 0.0m);
            part.PartGroupType = "PocBrdgAssY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

                    //TrackBolts
                    //part = new Part(3451, "TrackBoltsPoc", this, trackHelper.BridgeCount * 2, 0.0m);
                    //part.PartGroupType = "PocBrdgAssY-Parts";
                    //part.PartLabel = "";

                    //m_parts.Add(part);

                }
            }

            #endregion


        }

        #endregion


    }
}