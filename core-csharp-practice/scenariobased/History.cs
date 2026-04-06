using System;
using System.Collections.Generic;

class PageNode
{
    public string Url;
    public PageNode Prev;
    public PageNode Next;

    public PageNode(string url)
    {
        Url = url;
        Prev = null;
        Next = null;
    }
}

class BrowserTab
{
    private PageNode current;

    public void Visit(string url)
    {
        PageNode newPage = new PageNode(url);

        if (current != null)
        {
            current.Next = newPage;
            newPage.Prev = current;
        }

        current = newPage;
        Console.WriteLine("Visited: " + url);
    }

    public void Back()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Back to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No previous page");
        }
    }

    public void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Forward to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No next page");
        }
    }

    public string GetCurrentPage()
    {
        return current != null ? current.Url : "No page";
    }
}

// BrowserBuddy Manager
class BrowserBuddy
{
    private BrowserTab currentTab;
    private Stack<BrowserTab> closedTabs;

    public BrowserBuddy()
    {
        currentTab = new BrowserTab();
        closedTabs = new Stack<BrowserTab>();
    }

    public void VisitPage(string url)
    {
        currentTab.Visit(url);
    }

    public void Back()
    {
        currentTab.Back();
    }

    public void Forward()
    {
        currentTab.Forward();
    }

    public void CloseTab()
    {
        closedTabs.Push(currentTab);
        currentTab = new BrowserTab();
        Console.WriteLine("Tab closed");
    }

    public void RestoreTab()
    {
        if (closedTabs.Count > 0)
        {
            currentTab = closedTabs.Pop();
            Console.WriteLine("Tab restored");
        }
        else
        {
            Console.WriteLine("No closed tabs to restore");
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        BrowserBuddy browser = new BrowserBuddy();

        while (true)
        {
            Console.WriteLine("\n--- BrowserBuddy Menu ---");
            Console.WriteLine("1. Visit Page");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Close Tab");
            Console.WriteLine("5. Restore Tab");
            Console.WriteLine("6. Exit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter URL: ");
                    browser.VisitPage(Console.ReadLine());
                    break;

                case "2":
                    browser.Back();
                    break;

                case "3":
                    browser.Forward();
                    break;

                case "4":
                    browser.CloseTab();
                    break;

                case "5":
                    browser.RestoreTab();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
