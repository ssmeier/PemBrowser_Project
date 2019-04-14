using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic.New
{
    
        public class SessionHistory
        {
            Stack<Uri> backStack;
            Stack<Uri> forwardStack;

            public SessionHistory()
            {
                backStack = new Stack<Uri>();
                forwardStack = new Stack<Uri>();
            }


            public Uri PageForward(Uri currentUrl)
            {
                try
                {
                    addBackStack(currentUrl);
                    currentUrl = forwardStack.Pop();
                }
                catch { }
                return currentUrl;
            }
            public Uri PageBackward(Uri currentUrl)
            {
                try
                {
                    addForwardStack(currentUrl);
                    currentUrl = backStack.Pop();
                }
                catch { }
                return currentUrl;
            }

            public void addBackStack(Uri url)
            {
                if (backStack.Count == 0)
                {
                    backStack.Push(url);
                }

                else
                {
                    if (!(backStack.Peek().Equals(url)))
                    {
                        backStack.Push(url);
                    }
                }
            }

            public void addForwardStack(Uri url)
            {
                if (forwardStack.Count == 0)
                {
                    forwardStack.Push(url);
                }

                else
                {
                    if (!(forwardStack.Peek().Equals(url)))
                    {
                        forwardStack.Push(url);
                    }
                }
            }

            public Stack<Uri> getBackStack()
            {
                return backStack;
            }
            public void setBackStack(Stack<Uri> stack)
            {
                backStack = stack;
            }

        }

    }


