namespace Uni {
    [Serializable]
    public class Person {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() {
            ID = Guid.NewGuid();
        }
        public Person(string name, int age) {
            ID = Guid.NewGuid();
            Name = name;
            Age = age;
        }
        public void GetName() {
            //TODO:change type to string and implement method.
        }
        public void SetName(string name) {
            //TODO:implemment method.
        }
    }
}