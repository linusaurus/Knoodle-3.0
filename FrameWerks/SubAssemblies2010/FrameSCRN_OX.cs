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

namespace FrameWorks.Makes.System2010
{

    public class FrameSCRN_OX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 1;
        const decimal headRedX2 = 2.0m * 0.375m;
        const decimal frameRedX2 = 2.0m * 1.0m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameSCRN_OX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameSCRN_OX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadInt ^^
            part = new Part(4362, "SplitHeadInt", this, 1, m_subAssemblyWidth - headRedX2);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // SplitHeadExtX ^^
            part = new Part(4362, "SplitHeadExtX", this, 1, m_subAssemblyWidth - headRedX2);
            part.PartGroupType = "Frame";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - headRedX2);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(3979, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - headRedX2);
            part.PartGroupType = "Pile_LS_Seals";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head
            part = new Part(1688, "HDPE_Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPE_Head";
            part.PartLabel = "";
            part.PartThick = 0.75m;
            part.PartWidth = 1.125m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            
            #endregion

        }

        #endregion

    }

}














