using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> cartList = new List<Item>();
        private decimal storeProfit = 0;

        // Instantiate BindingSources to Bind TextBoxes to DataSets
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            storeItemsListBox.DataSource = itemsBinding;

            storeItemsListBox.DisplayMember = "itemDisplay";
            storeItemsListBox.ValueMember = "itemDisplay";

            cartBinding.DataSource = cartList;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "itemDisplay";
            shoppingCartListBox.ValueMember = "itemDisplay";

            vendorBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorBinding;

            vendorListBox.DisplayMember = "vendorDisplay";
            vendorListBox.ValueMember = "vendorDisplay";
        }
        
        // SetupData function sets up data to be used in textboxes
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Kevin", LastName = "DeLaune" });
            store.Vendors.Add(new Vendor { FirstName = "Kayla", LastName = "DeLaune" });
            store.Vendors.Add(new Vendor { FirstName = "Avelyn", LastName = "DeLaune" });
            store.Vendors.Add(new Vendor { FirstName = "Samuel", LastName = "DeLaune" });

            store.Items.Add(new Item
            {
                Title = "Jurassic Park",
                Description = "Movie about Dinosaurs",
                Price = 5.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Passion Of The Christ",
                Description = "Movie about the Death of Jesus Christ",
                Price = 7.25M,
                Owner = store.Vendors[3]
            });

            store.Items.Add(new Item
            {
                Title = "Lord Of The Rings",
                Description = "Movie about Hobbits and Kings",
                Price = 4.75M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Man Of Steel",
                Description = "Movie about Superman",
                Price = 6.50M,
                Owner = store.Vendors[2]
            });
        }

        // Add store items to shopping cart
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            // Select item from store and add to shopping cart
            Item itemSelected = (Item)storeItemsListBox.SelectedItem;
            cartList.Add(itemSelected);
            cartBinding.ResetBindings(false);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            // Loop through shopping cart list
            for (int i = 0; i < cartList.Count; i++)
            {
                // Mark each item in shopping cart list as sold
                cartList[i].Sold = true;

                // Calculate and add commission due to Vendor
                cartList[i].Owner.PaymentDue += (decimal)cartList[i].Owner.Commission * cartList[i].Price;

                // Calculate and add commission due to Store
                storeProfit += ( 1 - (decimal)cartList[i].Owner.Commission) * cartList[i].Price;

                // Remove sold items from store items once purchased
                if (itemsBinding.Contains(cartList[i]))
                {
                    itemsBinding.Remove(cartList[i]);
                }
            }
            // Remove sold items from shopping cart
            cartList.Clear();
            // Update storeProfitValue Label to reflect store profit
            storeProfitValue.Text = string.Format("{0:0.00}", storeProfit);

            // Resetting Bindings to update textboxes
            cartBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
        }
    }
}
