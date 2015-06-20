﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicObserver.Window.Dialog;
using ElectronicObserver.Notifier;
using ElectronicObserver.Window.Plugins;

namespace Headquarters
{
	public partial class Settings : PluginSettingControl
	{
		public Settings()
		{
			InitializeComponent();
		}


		public override bool Save()
		{
			var config = ElectronicObserver.Utility.Configuration.Config;

			config.FormHeadquarters.BlinkAtMaximum = FormHeadquarters_BlinkAtMaximum.Checked;

			var instance = ElectronicObserver.Utility.Configuration.Instance;
			var method = typeof( ElectronicObserver.Utility.Configuration ).GetMethod( "OnConfigurationChanged",
				System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic );
			method.Invoke( instance, null );

			return true;
		}

		private void Settings_Load( object sender, EventArgs e )
		{
			var config = ElectronicObserver.Utility.Configuration.Config;

			FormHeadquarters_BlinkAtMaximum.Checked = config.FormHeadquarters.BlinkAtMaximum;

		}
	}
}
