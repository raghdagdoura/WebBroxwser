using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webnavigateur
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void buttonStop_Click(object sender, EventArgs e)
    {
      webBrowser.Stop();
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
      webBrowser.Refresh();
    }

    private void buttonForward_Click(object sender, EventArgs e)
    {
      if(webBrowser.CanGoBack)
      {
        webBrowser.GoBack();
      }
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
      if(webBrowser.CanGoForward)
      {
        webBrowser.GoForward();
      }
    }

    private void AddressBar_TextChanged(object sender, EventArgs e)
    {

    }

    private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      string page = webBrowser.Url.ToString();
      AddressBar.Text = webBrowser.Url.ToString();
      History.Items.Add(page);
    }
    private void Navigate(string Adress)
    {
      if (string.IsNullOrEmpty(Adress)) return;
      if (Adress.Equals("about:blank")) return;
      if(!Adress.StartsWith("http://") && !Adress.StartsWith("https://"))
      {
        Adress = "https://" + Adress;
      }
      try
      {
        webBrowser.Navigate(new Uri(Adress));

      }
      catch (System.UriFormatException)
      {
        return;
      }
    }

    private void AddressBar_KeyDown(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Enter)
      {
        Navigate(AddressBar.Text);
      }
    }

    private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
    {
      webBrowser.GoHome();
    }

    private void buttonfav_Click(object sender, EventArgs e)
    {
      Favoris.Items.Add(webBrowser.Url.ToString());
    }

    private void Favoris_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        Navigate(Favoris.SelectedItem.ToString());
      }
      catch(NullReferenceException)
      {

      }
    }

    private void History_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        Navigate(History.SelectedItem.ToString());
      }
      catch (NullReferenceException)
      {

      }
    }
  }
}
