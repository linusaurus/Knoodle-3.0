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
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.System5010
{

    public class CrnSampAwnFrmSash : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const decimal frameReduce = 0.9375m;
        const decimal woodSashRed = 1.4025m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal gstopReduce = 1.875m;
        const decimal glassReduce = 2.21875m;
        const decimal gaskSashReduce = 2.1875m;
        const decimal edgeSealAdd = 0.375m;
        const decimal bronzeCrnBrk = 0.6250m;
        const decimal cnrBrktAlum = 0.44m;

        #endregion

        #region Constructor

        public CrnSampAwnFrmSash()

        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-CrnSampAwnFrmSash";
            this.WrkOrder = new Workorder(this, 1);
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;



            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // BrzOperWndVert
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4526, "BrzOperWndVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzOperWndHorz
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4526, "BrzOperWndHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodFrame

            //////////////////////////////////////////////////////////////////////////////

            // WoodOperWndVert
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4333, "WoodOperWndVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // WoodOperWndHorz
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4333, "WoodOperWndHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////           

            #endregion

            #region AssyBrackets

            //////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // AluCnrBrkt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(3206, "AluCnrBrkt", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            for (int i = 0; i < 80; i++)
            {
                part = new Part(1545, "SocSetScrw.25_20", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

                //FrameSeal
                part = new Part(2274, "FrameSeal", this, 1, peri / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            /////////////////////////////////////////////////////////////////////////////////

            #region SashBzAl

            // StileBzAl <<--
            for (int i = 0; i < 10; i++)

            {
                part = new Part(4862, "StileBzAl", this, 1, m_subAssemblyHieght - frameReduce);
                part.PartGroupType = "SashBzAl-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "Miter1End";

                m_parts.Add(part);
            }

            // RailBzAl ^^
            for (int i = 0; i < 10; i++)

            {
                part = new Part(4862, "RailBzAl", this, 1, m_subAssemblyWidth - frameReduce);
                part.PartGroupType = "SashBzAl-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelTopRail = "1)Miter1End";

                m_parts.Add(part);

            }

            #endregion

            #region WoodClad

            // StileWood <<--

            for (int i = 0; i < 10; i++)

            {
                part = new Part(4872, "StileWood", this, 1, m_subAssemblyHieght - woodSashRed);
                part.PartGroupType = "WoodClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }

            // RailWood ^^

            for (int i = 0; i < 10; i++)

            {
                part = new Part(4872, "RailWood", this, 1, m_subAssemblyWidth - woodSashRed);
                part.PartGroupType = "WoodClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelTopRail = "";

                m_parts.Add(part);

            }


            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4327, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - gstopReduce);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpHz
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4327, "AlumGlsStpHz", this, 1, m_subAssemblyWidth - gstopReduce);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopWdCld

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpVt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4331, "WoodGlsStpVt", this, 1, m_subAssemblyHieght - gstopReduce);
                part.PartGroupType = "StopWdCld-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpHz
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4331, "WoodGlsStpHz", this, 1, m_subAssemblyWidth - 2 * gstopReduce);
                part.PartGroupType = "StopWdCld-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssemblyHdw

            //////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum_0.44
            for (int i = 0; i < 10; i++)
            {
                part = new Part(5374, "AglBrktAlum_0.44", this, 1, cnrBrktAlum);
                part.PartGroupType = "AssemblyHdw-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            for (int i = 0; i < 40; i++)
            {
                part = new Part(1545, "SocSetScrw.25_20", this, 1, 0.0m);
                part.PartGroupType = "AssemblyHdw-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            //CornerBraceSS
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4855, "CornerBraceSS", this, 1, 0.0m);
                part.PartGroupType = "AssemblyHdw-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // MS_FlatHead_8-32x3/16_SS
            for (int i = 0; i < 40; i++)
            {
                part = new Part(502, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region PlexiGlass

            //PlexiGlassClear 
            for (int i = 0; i < 20; i++)

            {
                part = new Part(5513);

                part.FunctionalName = "PlexiGlassClear";
                part.PartGroupType = "PlexiGlassClear-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = m_subAssemblyWidth - (glassReduce);
                part.PartLength = m_subAssemblyHieght - (glassReduce);
                part.PartThick = 0.1875m;

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BlackWoodSpacerV
            for (int i = 0; i < 10; i++)
            {
                part = new Part(5175, "BlackWoodSpacerV", this, 1, m_subAssemblyHieght - glassReduce);
                part.PartGroupType = "PlexiGlass-Parts";
                part.PartWidth = 0.875m;
                part.PartThick = 0.50m;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            // BlackWoodSpacerH
            for (int i = 0; i < 10; i++)
            {
                part = new Part(5175, "BlackWoodSpacerH", this, 1, m_subAssemblyWidth - glassReduce);
                part.PartGroupType = "PlexiGlass-Parts";
                part.PartWidth = 0.875m;
                part.PartThick = 0.50m;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + edgeSealAdd, m_subAssemblyWidth + edgeSealAdd);

                //SashEdgeSeal
                part = new Part(2274, "SashEdgeSeal", this, 1, peri / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {

                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //GlazPreSetEPDM
                part = new Part(4314, "GlazPreSetEPDM", this, 1, peri / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 10; i++)
            {

                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //GlazWedgEPDM
                part = new Part(4284, "GlazWedgEPDM", this, 1, peri / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion


        }



        #endregion


    }
}