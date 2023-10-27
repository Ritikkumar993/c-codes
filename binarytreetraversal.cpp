// #include<bits/stdc++.h>
// using namespace std;

// struct node{
//     int data;
//     struct node* left;
//     struct node* right;

//     node(int val){
//         data=val;
//         left =NULL;
//         right = NULL;
//     }
// };

// int main(){
//     struct node* root=new node(1);
//     root->left=new node(2);
//     root->left->left=new node(4);
//     root->left->right=new node(5);
//     root->right=new node(3);
// }

#include <iostream>

class Base {
public:
    int data;
};

class Derived1 : virtual public Base {
public:
    Derived1() {
        data = 10;
    }
};

class Derived2 : virtual public Base {
public:
    Derived2() {
        data = 20;
    }
};

class Derived3 : public Derived1, public Derived2 {
public:
    void display() {
        std::cout << "Data: " << Derived2::data << std::endl;
    }
};

int main() {
    Derived3 obj;
    obj.display();
    return 0;
}