using LibraryLib.Classes;

namespace LibraryUi;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    ClientForm clientForm = new ClientForm();
    BookForm bookForm = new BookForm(); 
    OrderForm orderForm = new OrderForm();


    private void button1_Click_1(object sender, EventArgs e)
    {
        this.Hide();
        clientForm.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Hide();
        orderForm.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.Hide();
        bookForm.ShowDialog();
    }
}
