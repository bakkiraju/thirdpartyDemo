
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox3;

	private global::Gtk.ComboBoxEntry comboboxentry1;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.HBox hbox4;

	private global::Gtk.HScale hscale3;

	private global::Gtk.HSeparator hseparator2;

	private global::Gtk.HBox hbox5;

	private global::Gtk.SpinButton spinbutton1;

	private global::Gtk.HSeparator hseparator3;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry1.AppendText(global::Mono.Unix.Catalog.GetString("Hi"));
		this.comboboxentry1.AppendText(global::Mono.Unix.Catalog.GetString("Hello"));
		this.comboboxentry1.AppendText(global::Mono.Unix.Catalog.GetString("Jello"));
		this.comboboxentry1.AppendText(global::Mono.Unix.Catalog.GetString("Mellow"));
		this.comboboxentry1.Name = "comboboxentry1";
		this.hbox3.Add(this.comboboxentry1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.comboboxentry1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		this.vbox2.Add(this.hbox3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator();
		this.hseparator1.Name = "hseparator1";
		this.vbox2.Add(this.hseparator1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hscale3 = new global::Gtk.HScale(null);
		this.hscale3.CanFocus = true;
		this.hscale3.Events = ((global::Gdk.EventMask)(2097152));
		this.hscale3.Name = "hscale3";
		this.hscale3.Adjustment.Upper = 100;
		this.hscale3.Adjustment.PageIncrement = 10;
		this.hscale3.Adjustment.StepIncrement = 1;
		this.hscale3.Adjustment.Value = 34;
		this.hscale3.DrawValue = true;
		this.hscale3.Digits = 0;
		this.hscale3.ValuePos = ((global::Gtk.PositionType)(2));
		this.hbox4.Add(this.hscale3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hscale3]));
		w4.Position = 0;
		this.vbox2.Add(this.hbox4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator();
		this.hseparator2.Name = "hseparator2";
		this.vbox2.Add(this.hseparator2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator2]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.spinbutton1 = new global::Gtk.SpinButton(0, 100, 1);
		this.spinbutton1.CanFocus = true;
		this.spinbutton1.Name = "spinbutton1";
		this.spinbutton1.Adjustment.PageIncrement = 10;
		this.spinbutton1.ClimbRate = 1;
		this.spinbutton1.Numeric = true;
		this.hbox5.Add(this.spinbutton1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.spinbutton1]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox2.Add(this.hbox5);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
		w8.Position = 4;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hseparator3 = new global::Gtk.HSeparator();
		this.hseparator3.Name = "hseparator3";
		this.vbox2.Add(this.hseparator3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator3]));
		w9.Position = 5;
		w9.Expand = false;
		w9.Fill = false;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 667;
		this.DefaultHeight = 526;
		this.Show();
		this.hscale3.ValueChanged += new global::System.EventHandler(this.OnHscale3ValueChanged);
		this.hscale3.MoveSlider += new global::Gtk.MoveSliderHandler(this.OnHscale3MoveSlider);
	}
}
