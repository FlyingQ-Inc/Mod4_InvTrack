namespace Mod4_InvTrack
{
    public partial class frmInvTrack : Form
    {
        private string[] itemNames = new string[5];     // Array to hold item names
        private int[] itemQuantities = new int[5];      // Array to hold item quantities

        public frmInvTrack()
        {
            InitializeComponent();
            InitializeInventory();
            DisplayInventory();
        }

        private void InitializeInventory()      // Method to initialize inventory with default values
        {
            itemNames[0] = "Laptop";
            itemQuantities[0] = 15;

            itemNames[1] = "Monitor";
            itemQuantities[1] = 30;

            itemNames[2] = "Keyboard";
            itemQuantities[2] = 45;

            itemNames[3] = "Mouse";
            itemQuantities[3] = 50;

            itemNames[4] = "Headset";
            itemQuantities[4] = 20;
        }

        private void DisplayInventory()     // Method to display the inventory in the text box
        {
            textBox1.Clear();
            for (int i = 0; i < itemNames.Length; i++)
            {
                textBox1.AppendText($"{itemNames[i]}: {itemQuantities[i]}\r\n");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)       // Method to add quantity to an item in the inventory
        {
            if (int.TryParse(inputQuantity.Text, out int qty) && int.TryParse(inputIndex.Text, out int idx) && idx >= 0 && idx < itemQuantities.Length)     // Check if input is valid
            {
                itemQuantities[idx] += qty;
                DisplayInventory();
            }
            else
            {
                MessageBox.Show("Invalid input or index out of range.");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)      // Method to subtract quantity from an item in the inventory
        {
            if (int.TryParse(inputQuantity.Text, out int qty) && int.TryParse(inputIndex.Text, out int idx) && idx >= 0 && idx < itemQuantities.Length)     // Check if input is valid
            {
                itemQuantities[idx] = Math.Max(0, itemQuantities[idx] - qty);
                DisplayInventory();
            }
            else
            {
                MessageBox.Show("Invalid input or index out of range.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputQuantity.Clear();
            inputIndex.Clear();
        }
    }
}
