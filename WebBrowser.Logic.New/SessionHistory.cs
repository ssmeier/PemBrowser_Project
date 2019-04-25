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
            if (!(backStack.Contains(url)))
            {
                backStack.Push(url);
            }
            }

            public void addForwardStack(Uri url)
            {
                forwardStack.Push(url);
            }

            public Stack<Uri> getBackStack()
            {
                return backStack;
            }

            public void setBackStack(Stack<Uri> stack)
            {
                backStack = stack;
            }

            public Uri peekBackStack()
            {
            var result = new Uri("void");
            if (backStack.Count != 0)
            {
                result = backStack.Peek();
            }
            else
            { result = null; }
            return result;
            }

            public Stack<Uri> getForwardStack()
            {
                return forwardStack;
            }

            public void setForwardSrtack(Stack<Uri> stack)
            {
                forwardStack = stack;
            }

        }

    }


