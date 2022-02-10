//Copyright 2021, ALT LLC. All Rights Reserved.
//This file is part of Antilatency SDK.
//It is subject to the license terms in the LICENSE file found in the top-level directory
//of this distribution and at http://www.antilatency.com/eula
//You may not use this file except in compliance with the License.
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.
#pragma warning disable IDE1006 // Do not warn about naming style violations
#pragma warning disable IDE0017 // Do not suggest to simplify object initialization
using System.Runtime.InteropServices; //GuidAttribute
namespace Antilatency.Alt.Environment.Arbitrary2D {

[Guid("7dbbed9f-593b-426e-a9ff-cb8769293940")]
public interface IDeserializedEnvironment : Antilatency.InterfaceContract.IInterface {
	UnityEngine.Vector2[] getMarkers();
	float getHeight();
	Antilatency.InterfaceContract.Bool getFloor();
}
namespace Details {
	public class IDeserializedEnvironmentWrapper : Antilatency.InterfaceContract.Details.IInterfaceWrapper, IDeserializedEnvironment {
		private IDeserializedEnvironmentRemap.VMT _VMT = new IDeserializedEnvironmentRemap.VMT();
		protected new int GetTotalNativeMethodsCount() {
		    return base.GetTotalNativeMethodsCount() + typeof(IDeserializedEnvironmentRemap.VMT).GetFields().Length;
		}
		public IDeserializedEnvironmentWrapper(System.IntPtr obj) : base(obj) {
		    _VMT = LoadVMT<IDeserializedEnvironmentRemap.VMT>(base.GetTotalNativeMethodsCount());
		}
		public UnityEngine.Vector2[] getMarkers() {
			UnityEngine.Vector2[] result;
			var resultMarshaler = Antilatency.InterfaceContract.Details.ArrayOutMarshaler.create<UnityEngine.Vector2>();
			HandleExceptionCode(_VMT.getMarkers(_object, resultMarshaler));
			result = resultMarshaler.value;
			resultMarshaler.Dispose();
			return result;
		}
		public float getHeight() {
			float result;
			float resultMarshaler;
			HandleExceptionCode(_VMT.getHeight(_object, out resultMarshaler));
			result = resultMarshaler;
			return result;
		}
		public Antilatency.InterfaceContract.Bool getFloor() {
			Antilatency.InterfaceContract.Bool result;
			Antilatency.InterfaceContract.Bool resultMarshaler;
			HandleExceptionCode(_VMT.getFloor(_object, out resultMarshaler));
			result = resultMarshaler;
			return result;
		}
	}
	public class IDeserializedEnvironmentRemap : Antilatency.InterfaceContract.Details.IInterfaceRemap {
		public new struct VMT {
			public delegate Antilatency.InterfaceContract.ExceptionCode getMarkersDelegate(System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result);
			public delegate Antilatency.InterfaceContract.ExceptionCode getHeightDelegate(System.IntPtr _this, out float result);
			public delegate Antilatency.InterfaceContract.ExceptionCode getFloorDelegate(System.IntPtr _this, out Antilatency.InterfaceContract.Bool result);
			#pragma warning disable 0649
			public getMarkersDelegate getMarkers;
			public getHeightDelegate getHeight;
			public getFloorDelegate getFloor;
			#pragma warning restore 0649
		}
		public new static readonly NativeInterfaceVmt NativeVmt;
		static IDeserializedEnvironmentRemap() {
			var vmtBlocks = new System.Collections.Generic.List<object>();
			AppendVmt(vmtBlocks);
			NativeVmt = new NativeInterfaceVmt(vmtBlocks);
		}
		protected static new void AppendVmt(System.Collections.Generic.List<object> buffer) {
			Antilatency.InterfaceContract.Details.IInterfaceRemap.AppendVmt(buffer);
			var vmt = new VMT();
			vmt.getMarkers = (System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result) => {
				try {
					var obj = GetContext(_this) as IDeserializedEnvironment;
					var resultMarshaler = obj.getMarkers();
					result.assign(resultMarshaler);
				}
				catch (System.Exception ex) {
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			vmt.getHeight = (System.IntPtr _this, out float result) => {
				try {
					var obj = GetContext(_this) as IDeserializedEnvironment;
					var resultMarshaler = obj.getHeight();
					result = resultMarshaler;
				}
				catch (System.Exception ex) {
					result = default(float);
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			vmt.getFloor = (System.IntPtr _this, out Antilatency.InterfaceContract.Bool result) => {
				try {
					var obj = GetContext(_this) as IDeserializedEnvironment;
					var resultMarshaler = obj.getFloor();
					result = resultMarshaler;
				}
				catch (System.Exception ex) {
					result = default(Antilatency.InterfaceContract.Bool);
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			buffer.Add(vmt);
		}
		public IDeserializedEnvironmentRemap() { }
		public IDeserializedEnvironmentRemap(System.IntPtr context, ushort lifetimeId) {
			AllocateNativeInterface(NativeVmt.Handle, context, lifetimeId);
		}
	}
}

[Guid("c2df5d47-1d06-4467-93dc-46ccb7cbc320")]
public interface ILibrary : Antilatency.Alt.Environment.IEnvironmentConstructor {
	string serialize(UnityEngine.Vector2[] markers, float height, Antilatency.InterfaceContract.Bool floor);
	Antilatency.Alt.Environment.Arbitrary2D.IDeserializedEnvironment deserialize(string environmentData);
}
public static class Library{
    [DllImport("AntilatencyAltEnvironmentArbitrary2D")]
    private static extern Antilatency.InterfaceContract.ExceptionCode getLibraryInterface(System.IntPtr unloader, out System.IntPtr result);
    public static ILibrary load(){
        System.IntPtr libraryAsIInterfaceIntermediate;
        getLibraryInterface(System.IntPtr.Zero, out libraryAsIInterfaceIntermediate);
        Antilatency.InterfaceContract.IInterface libraryAsIInterface = new Antilatency.InterfaceContract.Details.IInterfaceWrapper(libraryAsIInterfaceIntermediate);
        var library = libraryAsIInterface.QueryInterface<ILibrary>();
        libraryAsIInterface.Dispose();
        return library;
    }
}
namespace Details {
	public class ILibraryWrapper : Antilatency.Alt.Environment.Details.IEnvironmentConstructorWrapper, ILibrary {
		private ILibraryRemap.VMT _VMT = new ILibraryRemap.VMT();
		protected new int GetTotalNativeMethodsCount() {
		    return base.GetTotalNativeMethodsCount() + typeof(ILibraryRemap.VMT).GetFields().Length;
		}
		public ILibraryWrapper(System.IntPtr obj) : base(obj) {
		    _VMT = LoadVMT<ILibraryRemap.VMT>(base.GetTotalNativeMethodsCount());
		}
		public string serialize(UnityEngine.Vector2[] markers, float height, Antilatency.InterfaceContract.Bool floor) {
			string result;
			var resultMarshaler = Antilatency.InterfaceContract.Details.ArrayOutMarshaler.create();
			var markersMarshaler = Antilatency.InterfaceContract.Details.ArrayInMarshaler.create(markers);
			HandleExceptionCode(_VMT.serialize(_object, markersMarshaler, height, floor, resultMarshaler));
			markersMarshaler.Dispose();
			result = resultMarshaler.value;
			resultMarshaler.Dispose();
			return result;
		}
		public Antilatency.Alt.Environment.Arbitrary2D.IDeserializedEnvironment deserialize(string environmentData) {
			Antilatency.Alt.Environment.Arbitrary2D.IDeserializedEnvironment result;
			System.IntPtr resultMarshaler;
			var environmentDataMarshaler = Antilatency.InterfaceContract.Details.ArrayInMarshaler.create(environmentData);
			HandleExceptionCode(_VMT.deserialize(_object, environmentDataMarshaler, out resultMarshaler));
			environmentDataMarshaler.Dispose();
			result = (resultMarshaler==System.IntPtr.Zero) ? null : new Antilatency.Alt.Environment.Arbitrary2D.Details.IDeserializedEnvironmentWrapper(resultMarshaler);
			return result;
		}
	}
	public class ILibraryRemap : Antilatency.Alt.Environment.Details.IEnvironmentConstructorRemap {
		public new struct VMT {
			public delegate Antilatency.InterfaceContract.ExceptionCode serializeDelegate(System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate markers, float height, Antilatency.InterfaceContract.Bool floor, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result);
			public delegate Antilatency.InterfaceContract.ExceptionCode deserializeDelegate(System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate environmentData, out System.IntPtr result);
			#pragma warning disable 0649
			public serializeDelegate serialize;
			public deserializeDelegate deserialize;
			#pragma warning restore 0649
		}
		public new static readonly NativeInterfaceVmt NativeVmt;
		static ILibraryRemap() {
			var vmtBlocks = new System.Collections.Generic.List<object>();
			AppendVmt(vmtBlocks);
			NativeVmt = new NativeInterfaceVmt(vmtBlocks);
		}
		protected static new void AppendVmt(System.Collections.Generic.List<object> buffer) {
			Antilatency.Alt.Environment.Details.IEnvironmentConstructorRemap.AppendVmt(buffer);
			var vmt = new VMT();
			vmt.serialize = (System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate markers, float height, Antilatency.InterfaceContract.Bool floor, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result) => {
				try {
					var obj = GetContext(_this) as ILibrary;
					var resultMarshaler = obj.serialize(markers.toArray<UnityEngine.Vector2>(), height, floor);
					result.assign(resultMarshaler);
				}
				catch (System.Exception ex) {
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			vmt.deserialize = (System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate environmentData, out System.IntPtr result) => {
				try {
					var obj = GetContext(_this) as ILibrary;
					var resultMarshaler = obj.deserialize(environmentData);
					result = Antilatency.InterfaceContract.Details.InterfaceMarshaler.ManagedToNative<Antilatency.Alt.Environment.Arbitrary2D.IDeserializedEnvironment>(resultMarshaler);
				}
				catch (System.Exception ex) {
					result = default(System.IntPtr);
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			buffer.Add(vmt);
		}
		public ILibraryRemap() { }
		public ILibraryRemap(System.IntPtr context, ushort lifetimeId) {
			AllocateNativeInterface(NativeVmt.Handle, context, lifetimeId);
		}
	}
}


}
