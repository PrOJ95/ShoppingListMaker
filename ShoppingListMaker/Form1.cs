namespace ShoppingListMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            removeButton.Enabled = false;
        }
        private List<Item> shoppingList = new List<Item>();
        decimal totalPrice = 0;
        decimal totalWeight = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            decimal price;
            while (!decimal.TryParse(pricetxt.Text, out price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pricetxt.Text = "";
                pricetxt.Focus();
                return;
            }
            Item item = new Item
            {
                Name = nametxt.Text,
                Price = price,
                Quantity = (int)quantitynum.Value,
                Weight = weightnum.Value
            };
            shoppingList.Add(item);
            UpdateList();
            totalPrice += price;
            currentTotalNum.Text = $"£{totalPrice}";
            totalWeight += weightnum.Value;
            currentWeightNum.Text = $"{totalWeight}g";
        }

        private void UpdateList()
        {
            shoppingListView.View = View.Details;
            shoppingListView.Columns.Add("Name");
            shoppingListView.Columns.Add("Price");
            shoppingListView.Columns.Add("Quantity");
            shoppingListView.Columns.Add("Weight");

            shoppingListView.Items.Clear();

            foreach (Item item in shoppingList)
            {
                string[] row = new string[]
                {
                    item.Name,
                    $"£{item.Price}",
                    item.Quantity.ToString(),
                    $"{item.Weight}g"
                };
                ListViewItem listViewItem = new ListViewItem(row);
                shoppingListView.Items.Add(listViewItem);
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (shoppingListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = shoppingListView.SelectedItems[0];
                Item item = shoppingList[selectedItem.Index];
                shoppingList.RemoveAt(selectedItem.Index);
                shoppingListView.Items.Remove(selectedItem);
                totalPrice -= item.Price;
                currentTotalNum.Text = $"£{totalPrice}";
                totalWeight -= item.Weight;
                currentWeightNum.Text = $"{totalWeight}g";
                removeButton.Enabled = false;
            }
        }
        private void shoppingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shoppingListView.SelectedItems.Count >= 0)
            {
                removeButton.Enabled = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the application?";
            const string caption = "Close application?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}