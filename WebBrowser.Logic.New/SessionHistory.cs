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
                    backStack.Pop();
                currentUrl = backStack.Pop();
                }
                catch { }
                return currentUrl;
            }

            public void addBackStack(Uri currentUrl)
            {
            if (backStack.Count == 0)
            {
                backStack.Push(currentUrl);
            }
            else if (!(currentUrl.AbsoluteUri.Equals(backStack.Peek().AbsoluteUri)))
            {
                backStack.Push(currentUrl);
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

            public Boolean justVisited(Uri currentURl)
        {
            var prevUrl = peekBackStack();
            if (prevUrl.AbsolutePath.Equals(prevUrl.AbsolutePath))
            {
                return true;
            }
            else return false;
        }
            

        }

    }


