
// This file has been generated by the GUI designer. Do not modify.
namespace ManagerIO_ConvertToTransfer
{
	public partial class SearchTransactionsWindow
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView transactionsTreeView;
		private global::Gtk.Table table3;
		private global::ManagerIO_ConvertToTransfer.BankAccountWidget bankAccountCombo;
		private global::Gtk.Button deleteButton;
		private global::Gtk.Entry descriptionLabel;
		private global::Gtk.Button findButton;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry startDate;
		private global::Gtk.Entry endDate;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Button selectAllButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ManagerIO_ConvertToTransfer.SearchTransactionsWindow
			this.Name = "ManagerIO_ConvertToTransfer.SearchTransactionsWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("SearchTransactionsWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ManagerIO_ConvertToTransfer.SearchTransactionsWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.transactionsTreeView = new global::Gtk.TreeView ();
			this.transactionsTreeView.CanFocus = true;
			this.transactionsTreeView.Name = "transactionsTreeView";
			this.GtkScrolledWindow.Add (this.transactionsTreeView);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(5)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.bankAccountCombo = null;
			this.table3.Add (this.bankAccountCombo);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3 [this.bankAccountCombo]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.deleteButton = new global::Gtk.Button ();
			this.deleteButton.CanFocus = true;
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.UseStock = true;
			this.deleteButton.UseUnderline = true;
			this.deleteButton.Label = "gtk-delete";
			this.table3.Add (this.deleteButton);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3 [this.deleteButton]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.descriptionLabel = new global::Gtk.Entry ();
			this.descriptionLabel.CanFocus = true;
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.IsEditable = true;
			this.descriptionLabel.InvisibleChar = '●';
			this.table3.Add (this.descriptionLabel);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3 [this.descriptionLabel]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.findButton = new global::Gtk.Button ();
			this.findButton.CanFocus = true;
			this.findButton.Name = "findButton";
			this.findButton.UseStock = true;
			this.findButton.UseUnderline = true;
			this.findButton.Label = "gtk-find";
			this.table3.Add (this.findButton);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3 [this.findButton]));
			w6.TopAttach = ((uint)(4));
			w6.BottomAttach = ((uint)(5));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.startDate = new global::Gtk.Entry ();
			this.startDate.CanFocus = true;
			this.startDate.Name = "startDate";
			this.startDate.Text = global::Mono.Unix.Catalog.GetString ("dd/mm/yyyy");
			this.startDate.IsEditable = true;
			this.startDate.WidthChars = 10;
			this.startDate.InvisibleChar = '●';
			this.hbox1.Add (this.startDate);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.startDate]));
			w7.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.endDate = new global::Gtk.Entry ();
			this.endDate.CanFocus = true;
			this.endDate.Name = "endDate";
			this.endDate.Text = global::Mono.Unix.Catalog.GetString ("dd/mm/yyyy");
			this.endDate.IsEditable = true;
			this.endDate.WidthChars = 10;
			this.endDate.InvisibleChar = '●';
			this.hbox1.Add (this.endDate);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.endDate]));
			w8.Position = 1;
			this.table3.Add (this.hbox1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3 [this.hbox1]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Bank account:");
			this.table3.Add (this.label1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3 [this.label1]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Dates:");
			this.table3.Add (this.label2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3 [this.label2]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Description:");
			this.table3.Add (this.label3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3 [this.label3]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.selectAllButton = new global::Gtk.Button ();
			this.selectAllButton.CanFocus = true;
			this.selectAllButton.Name = "selectAllButton";
			this.selectAllButton.UseUnderline = true;
			this.selectAllButton.Label = global::Mono.Unix.Catalog.GetString ("Select _All");
			this.table3.Add (this.selectAllButton);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3 [this.selectAllButton]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table3]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 763;
			this.DefaultHeight = 485;
			this.Show ();
			this.selectAllButton.Clicked += new global::System.EventHandler (this.OnSelectAllButtonClicked);
			this.findButton.Clicked += new global::System.EventHandler (this.OnFindButtonClicked);
			this.deleteButton.Clicked += new global::System.EventHandler (this.OnDeleteButtonClicked);
		}
	}
}
