﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlueKeyBind2.cs" company="LeagueSharp">
//   Copyright (C) 2015 LeagueSharp
//   
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//   
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <summary>
//   A custom implementation of <see cref="ADrawable{MenuKeyBind}" />
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LeagueSharp.SDK.Core.UI.IMenu.Skins.Blue2
{
    using LeagueSharp.SDK.Core.UI.IMenu.Skins.Blue;
    using LeagueSharp.SDK.Core.UI.IMenu.Values;
    using EloBuddy.SDK.Enumerations;
    using EloBuddy.SDK.Events;
    using EloBuddy.SDK.Menu.Values;
    using EloBuddy.SDK.Menu;
    using EloBuddy.SDK;
    using EloBuddy; using Enumerations;
    /// <summary>
    ///     A default implementation of <see cref="ADrawable{MenuKeyBind}" />
    /// </summary>
    public class BlueKeyBind2 : BlueKeyBind
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="BlueKeyBind2" /> class.
        /// </summary>
        /// <param name="component">
        ///     The menu component
        /// </param>
        public BlueKeyBind2(MenuKeyBind component)
            : base(component)
        {
        }

        #endregion
    }
}