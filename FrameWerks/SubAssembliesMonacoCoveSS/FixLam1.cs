﻿#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
' Portions Copyright 2014 WeaselWare Software
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

namespace FrameWorks.Makes.MonacoCoveSS
{

    public class FixLam1 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = 0.50m;
        const decimal stopReduce = 0.25m;
        const decimal stopRedMit = 0.0475m;
        const decimal cladMtrRed = 1.03125m;
        const decimal glassReduceX2 = 1.125m;
        const decimal glassReduce = 0.5625m;
        const decimal glsRedHook = 0.6250m;
        const decimal glsMtrRed = .43213835m;
        const decimal finToFin = 1.24785457m;

        static int createID;

        #endregion

        #region Constructor

        public FixLam1()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-FixLam1";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameAlum

            //////////////////////////////////////////////////////////////////////////////
            // AlumFixLamVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4142, "AlumFixLamVert", this, 1, m_subAssemblyHieght + 2.0m * finToFin);
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // AlumFixLamHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4142, "AlumFixLamHorz", this, 1, m_subAssemblyWidth + 2.0m * finToFin);
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopGls

            //////////////////////////////////////////////////////////////////////////////

            // GlassStopVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4073, "GlassStopVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopGls-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "MiterEnds";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            //  GlassStopTop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4073, "GlassStopTop", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopGls-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "MiterEnds";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // GlassStopBot
            for (int i = 0; i < 1; i++)
            {


                string crap;
                crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - stopReduceX2);
                part = new Part(4073, "GlassStopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopGls-Parts";
                part.PartLabel = "1)MiterEnds" + "\r\n" +
                                 "2)" + crap;

                m_parts.Add(part);


            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region 316SS_Clad_BB_Fin


            //////////////////////////////////////////////////////////////////////////////

            // FIG_SS_Clad_Vert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4165, "FLam_SS_Clad_Vert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "316SS_Clad_BB_Fin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // FIG_SS_Clad_Horz
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4165, "FLam_SS_Clad_Horz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "316SS_Clad_BB_Fin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass

            //Glass Panel

            part = new Part(4212);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduceX2);
            part.PartLength = m_subAssemblyHieght - (glassReduceX2);
            part.PartThick = .5625m;

            m_parts.Add(part);


            #endregion

            #region Hardware


            #endregion



        }



        #endregion


    }
}