/**
 * \file      Values.cs
 * \authors   F. Sovilla & M. Costa-Cabral
 * \version   1.0
 * \date      November 06. 2019
 * \brief     Enumeration of the values for the cards.
 *
 * \details   This enumeration is connected to the db and from a number we have the value of each card. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    /// <summary>
    /// Card's enumeration for the value
    /// </summary>
    enum Values
    {
        Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, PlusTwo, PlusFour, Inverse, Pass, Joker
    }
}
