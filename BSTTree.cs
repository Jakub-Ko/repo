using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Tree
    {
        public Node? root = null;

        public Tree()
        {

        }

        public void Add(int value)
        {
            // 1. Jeśli drzewo puste, stwórz korzeń
            if (this.root == null)
            {
                this.root = new Node(value);
                return;
            }

            Node current = this.root;

            while (true)
            {
                // Idziemy w LEWO (wartość mniejsza)
                if (value < current.value)
                {
                    if (current.left == null)
                    {
                        Node newNode = new Node(value);
                        newNode.parent = current; // WAŻNE: Ustawienie rodzica
                        current.left = newNode;   // Podpięcie dziecka
                        break;
                    }
                    current = current.left;
                }
                // Idziemy w PRAWO (wartość większa)
                else
                {
                    if (current.right == null)
                    {
                        Node newNode = new Node(value);
                        newNode.parent = current; // WAŻNE: Ustawienie rodzica
                        current.right = newNode;  // Podpięcie dziecka
                        break;
                    }
                    current = current.right;
                }
            }
        }

        private Node FindMin(Node node)
        {
            Node current = node;
            while (current.left != null)
            {
                current = current.left;
            }
            return current;
        }

        public void Remove(int value)
        {
            RemoveNode(this.root, value);
        }

        private void RemoveNode(Node node, int value)
        {
            if (node == null) return;

            if (value < node.value)
            {
                RemoveNode(node.left, value);
            }
            else if (value > node.value)
            {
                RemoveNode(node.right, value);
            }
            else
            {
                // ZNALEŹLIŚMY WĘZEŁ DO USUNIĘCIA

                // PRZYPADEK 1: Brak dzieci lub jedno dziecko (prawe)
                if (node.left == null)
                {
                    Transplant(node, node.right);
                }
                // PRZYPADEK 2: Jedno dziecko (lewe)
                else if (node.right == null)
                {
                    Transplant(node, node.left);
                }
                // PRZYPADEK 3: Dwoje dzieci
                else
                {
                    // Znajdź następnika (najmniejszy w prawym poddrzewie)
                    Node successor = FindMin(node.right);

                    // Podmieniamy wartość usuwanego węzła na wartość następnika
                    node.value = successor.value;

                    // Usuwamy następnika (on ma co najwyżej jedno dziecko)
                    // Uwaga: wywołujemy rekurencyjnie dla prawego poddrzewa
                    RemoveNode(node.right, successor.value);
                }
            }
        }

        // Metoda do "przepiencia" rodziców i dzieci z u do v
        private void Transplant(Node u, Node v)
        {
            if (u.parent == null) // u był korzeniem
            {
                this.root = v;
            }
            else if (u == u.parent.left) // u był lewym dzieckiem
            {
                u.parent.left = v;
            }
            else // u był prawym dzieckiem
            {
                u.parent.right = v;
            }

            if (v != null)
            {
                v.parent = u.parent; // Aktualizacja rodzica dziecka
            }
        }

        // Rotacja w PRAWO na węźle 'y'
        public void RotateRight(Node y)
        {
            if (y == null || y.left == null) return; // Nie da się rotować w prawo bez lewego dziecka

            Node x = y.left;        // x to lewe dziecko y (to ono wyjdzie wyżej)
            y.left = x.right;       // Przejęcie prawego poddrzewa x-a

            // Jeśli poddrzewo istnieje, aktualizujemy jego rodzica
            if (x.right != null)
            {
                x.right.parent = y;
            }

            x.parent = y.parent;    // x przejmuje rodzica y

            // Jeśli y był korzeniem, x staje się nowym korzeniem
            if (y.parent == null)
            {
                this.root = x;
            }
            // Jeśli y był prawym dzieckiem
            else if (y == y.parent.right)
            {
                y.parent.right = x;
            }
            // Jeśli y był lewym dzieckiem
            else
            {
                y.parent.left = x;
            }

            x.right = y;    // y staje się prawym dzieckiem x
            y.parent = x;   // aktualizacja rodzica y
        }

        // Rotacja w LEWO na węźle 'x' (symetrycznie)
        public void RotateLeft(Node x)
        {
            if (x == null || x.right == null) return;

            Node y = x.right;
            x.right = y.left;

            if (y.left != null)
            {
                y.left.parent = x;
            }

            y.parent = x.parent;

            if (x.parent == null)
            {
                this.root = y;
            }
            else if (x == x.parent.left)
            {
                x.parent.left = y;
            }
            else
            {
                x.parent.right = y;
            }

            y.left = x;
            x.parent = y;
        }

        public Node Find(int value)
        {
            Node current = this.root;
            while (current != null)
            {
                if (value == current.value)
                    return current;
                else if (value < current.value)
                    current = current.left;
                else
                    current = current.right;
            }
            return null; // Nie znaleziono
        }

        // GOTOWIEC PONIZEJ

        public Node? FindNodeWithID(int id)
        {
            return nodeIDSearch(this.root, id);
        }

        private Node? nodeIDSearch(Node? node, int id)
        {
            if (node == null)
                return null;

            if (node.GetUID() == id)
                return node;

            Node? l = nodeIDSearch(node.left, id);
            if (l != null)
                return l;
            return nodeIDSearch(node.right, id);
        }
    }
}
