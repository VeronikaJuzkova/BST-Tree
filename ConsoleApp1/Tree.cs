using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tree
    {
        Node _root ;
        public Tree()
        {
            Node _root = null ;
        }

        public void Insert(int value)
        {
            Node actualNode = _root ;
            while (actualNode != null) 
            {
                if (value < actualNode.value)
                {
                    actualNode = actualNode.leftChild;
                }
                else if (value > actualNode.value)
                {
                    actualNode = actualNode.rightChild;
                }

            }
            actualNode.value = value ;
        }

        public int Search(int value)
        {
            Node actualNode = _root ;
            int searched = 0 ;
            while (actualNode != null) 
            {
                if (value == actualNode.value) 
                {
                    searched = 1 ;
                }
                if (value < actualNode.value) 
                {
                    actualNode = actualNode.leftChild ;
                }
                if (value > actualNode.value) 
                {
                    actualNode = actualNode.rightChild ;
                }
            }
            return searched ;
        }

        public void Delete(int value)
        {
            Node actualNode = _root;
            Node deleting = null;
            while (actualNode != null) 
            {
                if (value == actualNode.value) 
                {
                    deleting = actualNode;
                }
                if (value < actualNode.value) 
                {
                    actualNode = actualNode.leftChild;
                }
                if (value > actualNode.value) 
                {
                    actualNode = actualNode.rightChild;
                }
            }
            if (deleting.leftChild != null)
            {
                if (deleting.rightChild != null)
                {
                    //BOTH
                    Node leftPart = deleting.leftChild;
                    deleting = deleting.rightChild;
                    actualNode = deleting;
                    while (actualNode != null)
                    {
                        if (leftPart.value  < actualNode.value)
                        {
                            actualNode = actualNode.leftChild;  
                        }
                        else if (leftPart.value > actualNode.value)
                        {
                            actualNode = actualNode.rightChild;
                        }
                    }
                    actualNode = leftPart;


                }
                else
                {
                    //JUST_L 
                    deleting.value = deleting.leftChild.value;
                }
            }
            else if (deleting.rightChild != null)
            {
                //JUST_R
                deleting.value = deleting.rightChild.value;
            }
            else
            {
                //NOTHING
                deleting = null;
            }



        }
    }
}

