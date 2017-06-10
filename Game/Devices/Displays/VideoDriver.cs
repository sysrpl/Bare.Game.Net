using System.Linq;
using static Bare.Interop.SDL2;

namespace Bare.Devices
{
    #region VideoDriver
    /// <summary>
    /// Video driver is a class containing the name of a driver.
    /// </summary>
    public sealed class VideoDriver
	{
		private int index;

		internal VideoDriver(int index)
		{
			this.index = index;
		}

        /// <summary>
        /// Gets the video driver name.
        /// </summary>
		public string Name
		{
			get
			{
                return SDL_GetVideoDriver(index);
			}
		}

        public override string ToString()
        {
            return string.Format("[VideoDriver: Name={0}]", Name);
        }
	}
    #endregion

    #region VideoDrivers List
    /// <summary>
    /// Video drivers is a list of VideoDriver items.
    /// </summary>
    public sealed class VideoDriverList : DeviceList<VideoDriver>
	{
		protected override VideoDriver GetItem(int index)
		{
			return new VideoDriver(index);
		}

		protected override int GetCount()
		{
            return SDL_GetNumVideoDrivers();
		}

        /// <summary>
        /// Gets the current video driver.
        /// </summary>
        public VideoDriver Current
        {
            get
            {
                string s = SDL_GetCurrentVideoDriver();
                return this.Where(v => v.Name == s).FirstOrDefault();
            }
        }
	}
	#endregion
}