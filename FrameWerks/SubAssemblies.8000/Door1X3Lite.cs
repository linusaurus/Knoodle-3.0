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
using FrameWorks.Makes.System8000;


namespace FrameWorks.Makes.System8000
{

    public class Door1X3Lite : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        const decimal gStopBotRed = 7.9375m;
        const decimal gStopTopRed = 4.9375m;
        const decimal gStopWidRedX2 = 4.9375m * 2.0m;
        const decimal munThkRedX2 = 0.3125m * 2.0m;
        const decimal glsGap2X = 0.0625m * 2.0m;
        const decimal glsGap6X = 0.0625m * 6.0m;

        //

        #endregion

        #region Constructor

        public Door1X3Lite()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System8000-Door1X3Lite";
        }

        #endregion

        #region Methods


        //Bill of Material
        public override void Build()
        {

            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region WoodStileRails

            ////////////////////////////////////////////////////////////////////////////////////

            // StileHinge
            for (int i = 0; i < 1; i++)
            {
                part = new Part(411, "StileHinge", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodStileRails";
                part.PartWidth = 5.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLatch
            for (int i = 0; i < 1; i++)
            {
                part = new Part(411, "StileLatch ", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodStileRails";
                part.PartWidth = 5.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(411, "RailTop", this, 1, m_subAssemblyWidth - gStopWidRedX2);
                part.PartGroupType = "WoodStileRails";
                part.PartWidth = 5.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            for (int i = 0; i < 1; i++)
            {
                part = new Part(412, "RailBot", this, 1, m_subAssemblyWidth - gStopWidRedX2);
                part.PartGroupType = "WoodStileRails";
                part.PartWidth = 8.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(600, "MuntHorz", this, 1,  m_subAssemblyWidth - gStopWidRedX2 );
                part.PartGroupType = "Muntins";
                part.PartWidth = 0.9375m;
                part.PartThick = 1.75m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopWood

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpVert
            for (int i = 0; i < 6; i++)
            {
                part = new Part(2375, "GlsStpVert", this, 1,(m_subAssemblyHieght - gStopTopRed - gStopBotRed - munThkRedX2) / 3.0m );
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Vert";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpTop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(2375, "GlsStpTop", this, 1, m_subAssemblyWidth - gStopWidRedX2 );
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Horz";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            // GlsStpBot
            for (int i = 0; i < 1; i++)
            {
                part = new Part(2375, "GlsStpBot", this, 1, m_subAssemblyWidth - gStopWidRedX2 );
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Horz";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            ////////////////////////////////////////////////////////////////////////////////////

            // GlassPanel
            for (int i = 0; i < 3; i++)
            {                
                part = new Part(911);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - gStopWidRedX2 - glsGap2X);
                part.PartLength = (m_subAssemblyHieght - gStopBotRed - gStopTopRed - munThkRedX2 - glsGap6X) / 3.0m;
                part.PartThick = 0.25m;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic

            ////////////////////////////////////////////////////////////////////////////////////

            // Hinges
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 6;
            }


            return result;
        }




        #endregion


    }



}