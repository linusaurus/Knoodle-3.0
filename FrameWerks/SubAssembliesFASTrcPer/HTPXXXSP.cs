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
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.SubAssembliesFASTrcPerft
{
    class HTPXXXSP : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 3;
        const decimal centerGap = 0.25m;
        const decimal pocketInset = 0.375m;
        const decimal pocketInset2X = 2.0m * 0.375m;
        const decimal overAlLessJ2X = 1.09375m * 2.0m;

        private decimal waste = decimal.Zero;

        #endregion

        #region Math Functions


        #endregion

        #region Constructor

        public HTPXXXSP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-HTPXXXSP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth, 0);

            BridgeGenie bridgeGenie = new BridgeGenie(2.25m);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            //////////////////////////////////////////////

            #region HEMOLELE

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // HemoXXXP_PXXX_screen
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4730, "HemoXXXP_PXXX_Scrn" +
                    "", this, 1, trackHelper.DoorPanelWidth * 4);
                part.PartGroupType = "HEMOLELE";
                part.PartLabel = "HEMOLELE";
                m_parts.Add(part);
            }


            // HemoXXXP_PXXX_screen
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4691, "CRL_SS_CVR", this, 1, trackHelper.DoorPanelWidth * 4);
                part.PartGroupType = "HEMOLELE";
                part.PartLabel = "CRL_SS_Cover";
                m_parts.Add(part);
            }

            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #region PVC_Pocket_Drain

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // PVC_Pocket_Drain
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5628, "PVC_Pocket_Drain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Pocket_Drain";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PVC_Drains

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // PVC_StrightDrain
            for (int i = 0; i < panelCount + 1; i++)
            {
                part = new Part(5633, "PVC_StrightDrain", this, 1, 0.0m);
                part.PartGroupType = "PVC_Drains";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region SS_Drains

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //SS_Drains
            for (int i = 0; i < trackHelper.DrainCount; i++)
            {
                part = new Part(4465, "SS_Drains", this, 1, 0.0m);
                part.PartGroupType = "SS_Drains";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

    }

    #endregion

}
