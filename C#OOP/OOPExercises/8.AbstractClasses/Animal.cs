using System;

abstract class Animal {
    public string Name {get; set;}

    public Animal(string name) {
        this.Name = name;
    }

    public void SetName(string name) {
        this.Name = name;
    }

    public string GetName() {
        return this.Name;
    }

    public abstract void Eat();
}