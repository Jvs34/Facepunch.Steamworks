using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamTV : SteamInterface
	{
		public override IntPtr GetInterfacePointer() => GetApi.SteamTV();
		
		
		internal ISteamTV()
		{
			SetupInterface();
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamTV_IsBroadcasting")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _IsBroadcasting( IntPtr self, ref int pnNumViewers );
		
		#endregion
		internal bool IsBroadcasting( ref int pnNumViewers )
		{
			var returnValue = _IsBroadcasting( Self, ref pnNumViewers );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamTV_AddBroadcastGameData")]
		private static extern void _AddBroadcastGameData( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValue );
		
		#endregion
		internal void AddBroadcastGameData( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValue )
		{
			_AddBroadcastGameData( Self, pchKey, pchValue );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamTV_RemoveBroadcastGameData")]
		private static extern void _RemoveBroadcastGameData( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey );
		
		#endregion
		internal void RemoveBroadcastGameData( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey )
		{
			_RemoveBroadcastGameData( Self, pchKey );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamTV_AddTimelineMarker")]
		private static extern void _AddTimelineMarker( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchTemplateName, [MarshalAs( UnmanagedType.U1 )] bool bPersistent, byte nColorR, byte nColorG, byte nColorB );
		
		#endregion
		internal void AddTimelineMarker( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchTemplateName, [MarshalAs( UnmanagedType.U1 )] bool bPersistent, byte nColorR, byte nColorG, byte nColorB )
		{
			_AddTimelineMarker( Self, pchTemplateName, bPersistent, nColorR, nColorG, nColorB );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamTV_RemoveTimelineMarker")]
		private static extern void _RemoveTimelineMarker( IntPtr self );
		
		#endregion
		internal void RemoveTimelineMarker()
		{
			_RemoveTimelineMarker( Self );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamTV_AddRegion")]
		private static extern uint _AddRegion( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchElementName, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchTimelineDataSection, ref SteamTVRegion_t pSteamTVRegion, SteamTVRegionBehavior eSteamTVRegionBehavior );
		
		#endregion
		internal uint AddRegion( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchElementName, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchTimelineDataSection, ref SteamTVRegion_t pSteamTVRegion, SteamTVRegionBehavior eSteamTVRegionBehavior )
		{
			var returnValue = _AddRegion( Self, pchElementName, pchTimelineDataSection, ref pSteamTVRegion, eSteamTVRegionBehavior );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamTV_RemoveRegion")]
		private static extern void _RemoveRegion( IntPtr self, uint unRegionHandle );
		
		#endregion
		internal void RemoveRegion( uint unRegionHandle )
		{
			_RemoveRegion( Self, unRegionHandle );
		}
		
	}
}
