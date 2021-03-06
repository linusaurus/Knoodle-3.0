#region Copyright (c) 2008 WeaselWare Software
/************************************************************************************
'
' Copyright  2008 WeaselWare Software 
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
' Portions Copyright 2007 WeaselWare Software
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

namespace FrameWorks.Makes.System3000
{

    public class Helper
    {

        public class SliderOXXHelper
        {

            #region Fields

            //this need to be moved to a parameter for more versatilely
            readonly decimal JAMBINSET = -2.0m * 0.375m;
            readonly decimal STILEWIDTH = 2.0625m;
            private int m_doorCount;
            private decimal m_openingWidth;
            private decimal m_adjustedWidth;
            private int m_doorRef;

            private decimal m_decimalDoorCount;
            private decimal m_FloorTrackLength;
            private decimal m_DoorPanelSize;
            private decimal m_TopTrackLength;
            private decimal m_division;

            #endregion

            #region Constructor

            public SliderOXXHelper(int doorCount, int doorRef, decimal openingWidth)
            {
                this.m_doorCount = doorCount;
                this.m_doorRef = doorRef;
                this.m_decimalDoorCount = Convert.ToDecimal(doorCount);
                this.m_openingWidth = openingWidth;



            }

            #endregion

            #region Properties

            public decimal Division
            {
                get
                {
                    m_division = decimal.Zero;
                    m_adjustedWidth = m_openingWidth + JAMBINSET;

                    m_division = m_adjustedWidth - STILEWIDTH;
                    m_division /= m_decimalDoorCount;


                    return Math.Round(m_division, 4);
                }

            }

            public decimal DoorPanelSize
            {
                get
                {
                    m_DoorPanelSize = decimal.Zero;
                    decimal t_doorStileWidth = Convert.ToDecimal((m_doorCount - 1)) * STILEWIDTH;
                    decimal t_adjustedOpeningWidth = m_openingWidth;
                    t_adjustedOpeningWidth += JAMBINSET;
                    t_adjustedOpeningWidth += t_doorStileWidth;
                    m_DoorPanelSize = t_adjustedOpeningWidth / Convert.ToDecimal(m_doorCount);
                    return Math.Round(m_DoorPanelSize, 4);

                }

            }
            public decimal FloorTrackLength
            {

                get
                {
                    m_FloorTrackLength = decimal.Zero;

                    decimal position = Convert.ToDecimal(m_doorRef);
                    //m_adjustedWidth = m_openingWidth + 0.25m;


                    if (m_doorRef == 1)
                    {
                        m_FloorTrackLength = (m_openingWidth + 2.00m);
                    }
                    // Last Door Only
                    else if (m_doorRef == m_doorCount)
                    {
                        m_FloorTrackLength = (((m_decimalDoorCount + 1.0m) - position) * Division);
                        m_FloorTrackLength += STILEWIDTH;

                        m_FloorTrackLength +=  .375m + 1.0m + 5.6875m ;
                    }
                    //All Middle Doors
                    else if ((m_doorRef != 1) && (m_doorRef < m_doorCount))
                    {
                        m_FloorTrackLength = (((m_decimalDoorCount + 1.0m) - position) * Division);
                        m_FloorTrackLength += STILEWIDTH;
                   
                        m_FloorTrackLength += .375m + 2.6875m;

                    }


                    return Math.Round(m_FloorTrackLength, 4);

                }

            }

            public decimal TopTrackLength
            {
                get
                {

                    m_TopTrackLength = decimal.Zero;

                    decimal position = Convert.ToDecimal(m_doorRef);
                    m_adjustedWidth = m_openingWidth + 0.375m;

                    // First Door
                    if (m_doorRef == 1)
                    {
                        m_TopTrackLength = (m_openingWidth  - 0.1875m - 0.09375m );
                    }
                    // Last Door Only

                    else if(m_doorRef == m_doorCount)
	                {
                        m_TopTrackLength = (((m_decimalDoorCount + 1.0m) - position) * Division);
                        m_TopTrackLength += STILEWIDTH;

                        m_TopTrackLength += 0.375m -0.1875m + 4.625m;
	                }
                    //All Middle Doors
                    else if((m_doorRef != 1) && (m_doorRef < m_doorCount) )
                    {

                        m_TopTrackLength = (((m_decimalDoorCount + 1.0m) - position) * Division);
                        m_TopTrackLength += STILEWIDTH;

                        m_TopTrackLength +=  0.375m - 0.09375m + 0.59375m;


                    }


                    return Math.Round(m_TopTrackLength, 4);

                }

            }

            #endregion


        }












        public class SliderPXHelper
        {

            #region Fields

            //this need to be moved to a parameter for more versatilely
            readonly decimal JAMBINSET = -0.375m;
            readonly decimal STILEWIDTH = 2.0625m;
            private int m_doorCount;
            private decimal m_openingWidth;
            private decimal m_adjustedWidth;
            //private decimal m_openingDivision;
            private int m_doorRef;

            private decimal m_decimalDoorCount;
            private decimal m_FloorTrackLength;
            private decimal m_DoorPanelSize;
            private decimal m_TopTrackLength;
            private decimal m_division;
            private decimal m_head;

            #endregion

            #region Constructor

            public SliderPXHelper(int doorCount, int doorRef, decimal openingWidth)
            {
                this.m_doorCount = doorCount;
                this.m_doorRef = doorRef;
                this.m_decimalDoorCount = Convert.ToDecimal(doorCount);
                this.m_openingWidth = openingWidth;



            }

            #endregion

            #region Properties

            public decimal Division
            {
                get
                {
                    m_division = decimal.Zero;
                    m_adjustedWidth = m_openingWidth + JAMBINSET;

                    m_division = m_adjustedWidth - STILEWIDTH;
                    m_division /= m_decimalDoorCount;


                    return Math.Round(m_division, 4);
                }

            }

            public decimal DoorPanelSize
            {
                get
                {
                    m_DoorPanelSize = decimal.Zero;
                    decimal t_doorStileWidth = Convert.ToDecimal((m_doorCount - 1)) * STILEWIDTH;
                    decimal t_adjustedOpeningWidth = m_openingWidth;
                    t_adjustedOpeningWidth += JAMBINSET;
                    t_adjustedOpeningWidth += t_doorStileWidth;
                    m_DoorPanelSize = t_adjustedOpeningWidth / Convert.ToDecimal(m_doorCount);
                    return Math.Round(m_DoorPanelSize, 4);

                }

            }
            public decimal FloorTrackLength
            {

                get
                {
                    m_FloorTrackLength = decimal.Zero;

                    decimal position = Convert.ToDecimal(m_doorRef);
                    //m_adjustedWidth = m_openingWidth + 0.25m;


                    if (m_doorRef == 1)
                    {
                        m_FloorTrackLength = (m_openingWidth + DoorPanelSize + JAMBINSET + 2.00m);
                    }
                    else
                    {
                        m_FloorTrackLength = (((m_decimalDoorCount + 1.0m) - position) * Division);
                        m_FloorTrackLength += STILEWIDTH;
                        m_FloorTrackLength += DoorPanelSize;
                        m_FloorTrackLength += 2.6875m;

                    }


                    return Math.Round(m_FloorTrackLength, 4);

                }

            }
            public decimal Head
            {
                get
                {

                    m_head = decimal.Zero;


                    if (m_doorRef == 1)
                    {
                        m_head = m_openingWidth + DoorPanelSize + (2.00m + 0.625m);
                    }
                    else
                    {
                        m_head = TopTrackLength + 3.625m;

                    }

                    return Math.Round(m_head, 4);

                }

            }
            public decimal TopTrackLength
            {
                get
                {

                    m_TopTrackLength = decimal.Zero;

                    decimal position = Convert.ToDecimal(m_doorRef);
                    m_adjustedWidth = m_openingWidth + 0.375m;


                    if (m_doorRef == 1)
                    {
                        m_TopTrackLength = (m_openingWidth + DoorPanelSize + 0.375m);
                    }
                    else
                    {

                        m_TopTrackLength = (((m_decimalDoorCount + 1.0m) - position) * Division);
                        m_TopTrackLength += STILEWIDTH;
                        m_TopTrackLength += DoorPanelSize;


                    }


                    return Math.Round(m_TopTrackLength, 4);

                }

            }

            #endregion


        }

    }
}