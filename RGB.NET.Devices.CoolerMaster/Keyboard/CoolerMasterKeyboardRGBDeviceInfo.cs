﻿using System.Globalization;
using RGB.NET.Core;

namespace RGB.NET.Devices.CoolerMaster
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a generic information for a <see cref="T:RGB.NET.Devices.CoolerMaster.CoolerMasterKeyboardRGBDevice" />.
    /// </summary>
    public class CoolerMasterKeyboardRGBDeviceInfo : CoolerMasterRGBDeviceInfo
    {
        #region Properties & Fields

        /// <summary>
        /// Gets the <see cref="CoolerMasterPhysicalKeyboardLayout"/> of the <see cref="CoolerMasterKeyboardRGBDevice"/>.
        /// </summary>
        public CoolerMasterPhysicalKeyboardLayout PhysicalLayout { get; }

        /// <summary>
        /// Gets the <see cref="CoolerMasterLogicalKeyboardLayout"/> of the <see cref="CoolerMasterKeyboardRGBDevice"/>.
        /// </summary>
        public CoolerMasterLogicalKeyboardLayout LogicalLayout { get; private set; }

        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Internal constructor of managed <see cref="T:RGB.NET.Devices.CoolerMaster.CoolerMasterKeyboardRGBDeviceInfo" />.
        /// </summary>
        /// <param name="deviceIndex">The index of the <see cref="T:RGB.NET.Devices.CoolerMaster.CoolerMasterKeyboardRGBDevice" />.</param>
        /// <param name="physicalKeyboardLayout">The <see cref="T:RGB.NET.Devices.CoolerMaster.CoolerMasterPhysicalKeyboardLayout" /> of the <see cref="T:RGB.NET.Devices.CoolerMaster.CoolerMasterKeyboardRGBDevice" />.</param>
        /// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> of the layout this keyboard is using</param>
        internal CoolerMasterKeyboardRGBDeviceInfo(CoolerMasterDevicesIndexes deviceIndex, CoolerMasterPhysicalKeyboardLayout physicalKeyboardLayout, CultureInfo culture)
                : base(RGBDeviceType.Keyboard, deviceIndex)
        {
            this.PhysicalLayout = physicalKeyboardLayout;

            SetLayouts(culture.KeyboardLayoutId);
        }

        private void SetLayouts(int keyboardLayoutId)
        {
            switch (keyboardLayoutId)
            {
                //TODO DarthAffe 02.04.2017: Check all available keyboards and there layout-ids
                default:
                    LogicalLayout = CoolerMasterLogicalKeyboardLayout.DE;
                    break;
            }
        }

        #endregion
    }
}
