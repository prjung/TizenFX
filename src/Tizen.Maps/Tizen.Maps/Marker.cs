﻿/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using ElmSharp;

namespace Tizen.Maps
{
    /// <summary>
    /// Marker map object
    /// </summary>
    /// <since_tizen>3</since_tizen>
    public class Marker : MapObject, IDisposable
    {
        internal Interop.MarkerHandle handle;

        internal Marker(Geocoordinates coordinates, string imagePath, Interop.ViewMarkerType type)
        {
            var err = Interop.ErrorCode.InvalidParameter;
            if (coordinates == null || imagePath == null)
            {
                err.ThrowIfFailed("given coordinates or imagePath is null");
            }
            handle = new Interop.MarkerHandle(coordinates.handle, imagePath, type);
        }

        /// <summary>
        /// Gets or sets clicked event handlers.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        public event EventHandler Clicked;

        /// <summary>
        /// Gets or sets marker's visibility.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        public override bool IsVisible
        {
            get
            {
                return handle.IsVisible;
            }
            set
            {
                handle.IsVisible = value;
            }
        }

        /// <summary>
        /// Gets or sets geographical coordinates for this marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        public Geocoordinates Coordinates
        {
            get
            {
                return new Geocoordinates(handle.Coordinates);
            }
            set
            {
                handle.Coordinates = value.handle;

                // Marker takes ownership of the native handle.
                value.handle.HasOwnership = false;
            }
        }

        /// <summary>
        /// Gets or sets a string representing image file path for this marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        public string ImagePath
        {
            get
            {
                return handle.ImageFile;
            }
            set
            {
                handle.ImageFile = value;
            }
        }

        /// <summary>
        /// Gets or sets screen size for this marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        public Size MarkerSize
        {
            get
            {
                return handle.MarkerSize;
            }
            set
            {
                handle.MarkerSize = value;
            }
        }

        /// <summary>
        /// Gets or sets z-order for this marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        /// <value>The integer value is 0 in default, and must be in range of from -100 to 100.</value>
        public int ZOrder
        {
            get
            {
                return handle.ZOrder;
            }
            set
            {
                handle.ZOrder = value;
            }
        }

        /// <summary>
        /// Changes marker size.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        /// <param name="newSize">New size</param>
        public void Resize(Size newSize)
        {
            MarkerSize = newSize;
        }

        /// <summary>
        /// Changes marker coordinates.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        /// <param name="newPosition">New position for marker</param>
        public void Move(Geocoordinates newPosition)
        {
            Coordinates = newPosition;
        }

        internal override void HandleClickedEvent()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        internal override void InvalidateMapObject()
        {
            handle = null;
        }

        internal override Interop.ViewObjectHandle GetHandle()
        {
            return handle;
        }

        #region IDisposable Support
        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                handle.Dispose();
                _disposedValue = true;
            }
        }

        /// <summary>
        /// Releases all resources used by this object.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
    }

    /// <summary>
    /// Pin type marker map object
    /// </summary>
    /// <since_tizen>3</since_tizen>
    public class Pin : Marker
    {
        private const string defaultImagePath = "/usr/share/dotnet.tizen/framework/res/maps_marker_pin_48.png";

        /// <summary>
        /// Creates a Pin type marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        /// <param name="coordinates">Marker coordinates</param>
        /// <exception cref="System.ArgumentException">Thrown when input coordinates are invalid.</exception>
        public Pin(Geocoordinates coordinates)
            : base(coordinates, defaultImagePath, Interop.ViewMarkerType.Pin)
        {
        }

        /// <summary>
        /// Creates a Pin type marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        /// <param name="coordinates">Marker coordinates</param>
        /// <param name="imagePath">Image file path for Marker</param>
        /// <remarks>
        /// http://tizen.org/privilege/mediastorage is needed if the file path are relevant to media storage.
        /// http://tizen.org/privilege/externalstorage is needed if the file path are relevant to external storage.
        /// </remarks>
        /// <exception cref="System.NotSupportedException">Thrown when the required feature is not supported.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Thrown when application does not have some privilege to access this method.</exception>
        /// <exception cref="System.ArgumentException">Thrown when input coordinates or imagePath are invalid.</exception>
        public Pin(Geocoordinates coordinates, string imagePath)
            : base(coordinates, imagePath, Interop.ViewMarkerType.Pin)
        {
        }
    }

    /// <summary>
    /// Sticker type marker map object
    /// </summary>
    /// <since_tizen>3</since_tizen>
    public class Sticker : Marker
    {
        private const string defaultImagePath = "/usr/share/dotnet.tizen/framework/res/maps_marker_sticker_48.png";

        /// <summary>
        /// Creates a Sticker type marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        /// <param name="coordinates">Marker coordinates</param>
        /// <exception cref="System.ArgumentException">Thrown when input coordinates are invalid.</exception>
        public Sticker(Geocoordinates coordinates)
            : base(coordinates, defaultImagePath, Interop.ViewMarkerType.Sticker)
        {
        }

        /// <summary>
        /// Creates a Sticker type marker.
        /// </summary>
        /// <since_tizen>3</since_tizen>
        /// <param name="coordinates">Marker coordinates</param>
        /// <param name="imagePath">Image file path for Marker</param>
        /// <remarks>
        /// http://tizen.org/privilege/mediastorage is needed if input or output path are relevant to media storage.
        /// http://tizen.org/privilege/externalstorage is needed if input or output path are relevant to external storage.
        /// </remarks>
        /// <exception cref="System.NotSupportedException">Thrown when the required feature is not supported.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Thrown when application does not have some privilege to access this method.</exception>
        /// <exception cref="System.ArgumentException">Thrown when input coordinates or imagePath are invalid.</exception>
        public Sticker(Geocoordinates coordinates, string imagePath)
            : base(coordinates, imagePath, Interop.ViewMarkerType.Sticker)
        {
        }
    }
}