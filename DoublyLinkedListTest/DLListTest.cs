using DoublyLinkedListWithErrors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DoublyLinkedListTest
{
    [TestClass]
    public class DLListTest
    {
        /// <summary>
        /// Add to the tail of the doubly linked list, where the node is null
        /// </summary>
        [TestMethod]
        public void addToTail_nodeIsNull()
        {
            DLList list = new DLList();
            list.addToTail(null);
        } // end of addToTail_nodeIsNull

        /// <summary>
        /// Add to the tail of the doubly linked list, where the head of the doubly linked list is null
        /// </summary>
        [TestMethod]
        public void addToTail_headIsNull()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(1);
            list.addToTail(node);
        } // end of addToTail_headIsNull

        /// <summary>
        /// Add to the tail of the doubly linked list, where the head of the doubly linked list is not null
        /// </summary>
        [TestMethod]
        public void addToTail_headIsNotNull()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
        } // end of addToTail_headIsNotNull

        /// <summary>
        /// Add to the head of the doubly linked list, where the node is null
        /// </summary>
        [TestMethod]
        public void addToHead_nodeIsNull()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(1);
            list.addToHead(node);
        } // end of addToHead_nodeIsNull

        /// <summary>
        /// Add to the head of the doubly linked list, where the head of the doubly linked list is null
        /// </summary>
        [TestMethod]
        public void addToHead_headIsNull()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(1);
            list.addToHead(node);
        } // end of addToHead_headIsNull

        /// <summary>
        /// Add to the head of the doubly linked list, where the head of the doubly linked list is not null
        /// </summary>
        [TestMethod]
        public void addToHead_headIsNotNull()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToHead(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToHead(node2);
        } // end of addToHead_headIsNotNull

        /// <summary>
        /// Remove to the head of the doubly linked list, where the head of the doubly linked list is null
        /// </summary>
        [TestMethod]
        public void removeHead_headIsNull()
        {
            DLList list = new DLList();
            list.removHead();
        } // end of removeHead_headIsNull

        /// <summary>
        /// Remove to the head of the doubly linked list, where the head of the doubly linked list is not null, the doubly linked length is 1
        /// </summary>
        [TestMethod]
        public void removeHead_headIsNotNull_listCountIs1()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(1);
            list.addToHead(node);
            list.removHead();
        } // end of removeHead_headIsNotNull_listCountEqual1

        /// <summary>
        /// Remove to the head of the doubly linked list, where the head of the doubly linked list is not null, the doubly linked length more than 1
        /// </summary>
        [TestMethod]
        public void removeHead_headIsNotNull_listCountMoreThan1()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToHead(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToHead(node2);
            list.removHead();
        } // end of removeHead_headIsNotNull_listCountMoreThan1

        /// <summary>
        /// Remove to the tail of the doubly linked list, where the tail of the doubly linked list is null
        /// </summary>
        [TestMethod]
        public void removeTail_tailIsNull()
        {
            DLList list = new DLList();
            list.removeTail();
        } // end of removeTail_tailIsNull

        /// <summary>
        /// Remove to the tail of the doubly linked list, where the tail of the doubly linked list is not null, the doubly linked length is 1
        /// </summary>
        [TestMethod]
        public void removeTail_tailEqualHead()
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(1);
            list.addToTail(node);
            list.removeTail();
        } // end of removeTail_tailEqualHead

        /// <summary>
        /// Remove to the tail of the doubly linked list, where the tail of the doubly linked list is not null, the doubly linked length more than 1.
        /// </summary>
        [TestMethod]
        public void removeTail_tailNotEqualHead()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            list.removeTail();
        } // end of removeTail_tailNotEqualHead

        /// <summary>
        /// Search in the doubly linked list, where the head of the doubly linked list is null
        /// </summary>
        [TestMethod]
        public void search_headIsNull()
        {
            DLList list = new DLList();
            DLLNode node = list.search(1);
        } // end of search_headIsNull

        /// <summary>
        /// Search in the doubly linked list, where the head of the doubly linked list is not null, the head is the search result
        /// </summary>
        [TestMethod]
        public void search_headIsNotNull_headEqual()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            DLLNode node = list.search(1);
        } // end of search_headIsNotNull_headEqual

        /// <summary>
        /// Search in the doubly linked list, where the head of the doubly linked list is not null, the tail is the search result
        /// </summary>
        [TestMethod]
        public void search_headIsNotNull_tailEqual()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            DLLNode node = list.search(3);
        } // end of search_headIsNotNull_tailEqual

        /// <summary>
        /// Search in the doubly linked list, where the head of the doubly linked list is not null, the other node is the search result
        /// </summary>
        [TestMethod]
        public void search_headIsNotNull_otherEqual()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            DLLNode node = list.search(2);
        } // end of search_headIsNotNull_otherEqual

        /// <summary>
        /// Search in the doubly linked list, where the head of the doubly linked list is not null, noother node is the search result
        /// </summary>
        [TestMethod]
        public void search_headIsNotNull_notherEqual()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            DLLNode node = list.search(4);
        } // end of search_headIsNotNull_notherEqual

        /// <summary>
        /// Remove a node from the doubly linked list, and the next of the removed node is null
        /// </summary>
        [TestMethod]
        public void removeNode_nextIsNull()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            list.removeNode(node3);
        } // end of removeNode_nextIsNull

        /// <summary>
        /// Remove a node from the doubly linked list, and the previous of the removed node is null
        /// </summary>
        [TestMethod]
        public void removeNode_previousIsNull()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            list.removeNode(node1);
        } // end of removeNode_previousIsNull

        /// <summary>
        /// Remove a node from the doubly linked list, and the previous and the next of the removed node is not null
        /// </summary>
        [TestMethod]
        public void removeNode_nextAndPreviousIsNotNull()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            list.removeNode(node2);
        } // end of removeNode_nextAndPreviousIsNotNull

        /// <summary>
        /// Remove a node from the doubly linked list, and the node is null
        /// </summary>
        [TestMethod]
        public void removeNode_nodeIsNull()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            list.removeNode(null);
        } // end of removeNode_nodeIsNull

        /// <summary>
        /// Statistical the length of the doubly linked list, where the head of the doubly linked list is null
        /// </summary>
        [TestMethod]
        public void total_headIsNull()
        {
            DLList list = new DLList();
            int total = list.total();
        } // end of total_headIsNull

        /// <summary>
        /// Statistical the length of the doubly linked list, where the head of the doubly linked list is not null
        /// </summary>
        [TestMethod]
        public void total_headIsNotNull()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            list.addToTail(node1);
            DLLNode node2 = new DLLNode(2);
            list.addToTail(node2);
            DLLNode node3 = new DLLNode(3);
            list.addToTail(node3);
            DLLNode node = list.search(3);
            int total = list.total();
        } // end of total_headIsNotNull
    }
}
