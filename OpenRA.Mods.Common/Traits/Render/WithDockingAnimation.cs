#region Copyright & License Information
/*
 * Copyright 2007-2015 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using OpenRA.Traits;

namespace OpenRA.Mods.Common.Traits
{
	public class WithDockingAnimationInfo : TraitInfo<WithDockingAnimation>, Requires<WithSpriteBodyInfo>, Requires<HarvesterInfo>
	{
		[Desc("Displayed when docking to refinery.")]
		[SequenceReference] public readonly string DockSequence = "dock";

		[Desc("Looped while unloading at refinery.")]
		[SequenceReference] public readonly string DockLoopSequence = "dock-loop";
	}

	public class WithDockingAnimation { }
}
