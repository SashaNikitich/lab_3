namespace lab_3.Tests
{
    /// <summary>
    /// Contains unit tests for the <see cref="NPC"/> class using the NUnit framework.
    /// </summary>
    [TestFixture]
    public class NPCTests
    {
        private NPC[] _testNpcs;

        /// <summary>
        /// Sets up the test environment before each test method.
        /// Initializes a sample array of NPC objects.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _testNpcs = new[]
            {
                new NPC("Sasha", "Nikitich", "programming", 67, 17),
                new NPC("Bogdan", "Tsiapko", "programming", 100, 17),
                new NPC("Dmytro", "Pankevich", "cooking", 911, 19)
            };
        }

        /// <summary>
        /// Verifies that the Equals method returns true when two NPC objects have identical data.
        /// </summary>
        [Test]
        public void Equals_SameData_ReturnsTrue()
        {
            // Arrange
            var npc1 = new NPC("Test", "User", "Hobby", 10, 20);
            var npc2 = new NPC("Test", "User", "Hobby", 10, 20);

            // Act & Assert
            Assert.That(npc1.Equals(npc2), Is.True, "Objects with identical data should be considered equal.");
        }

        /// <summary>
        /// Validates the sorting logic: Age ascending, then XP descending.
        /// </summary>
        [Test]
        public void Sorting_AgeAscendingXPDescending_IsCorrect()
        {
            // Act
            var sorted = _testNpcs
                .OrderBy(n => n.Age)
                .ThenByDescending(n => n.XP)
                .ToArray();

            // Assert
            Assert.Multiple(() =>
            {
                // Bogdan should be first (Age 17, 100 XP) before Sasha (Age 17, 67 XP)
                Assert.That(sorted[0].Name, Is.EqualTo("Bogdan"));
                Assert.That(sorted[1].Name, Is.EqualTo("Sasha"));
                Assert.That(sorted[2].Age, Is.EqualTo(19));
            });
        }

        /// <summary>
        /// Ensures that Array.Find correctly identifies an NPC object identical to the target.
        /// </summary>
        [Test]
        public void ArrayFind_TargetExists_ReturnsCorrectObject()
        {
            // Arrange
            var target = new NPC("Sasha", "Nikitich", "programming", 67, 17);

            // Act
            var found = Array.Find(_testNpcs, n => n.Equals(target));

            // Assert
            Assert.That(found, Is.Not.Null, "The search should return an object.");
            Assert.That(found.Surename, Is.EqualTo("Nikitich"));
        }

        /// <summary>
        /// Tests the NPC constructor to ensure all properties are initialized correctly.
        /// Uses parameters to verify multiple data sets.
        /// </summary>
        /// <param name="name">Expected name.</param>
        /// <param name="surname">Expected surname.</param>
        /// <param name="hobby">Expected hobby.</param>
        /// <param name="xp">Expected experience points.</param>
        /// <param name="age">Expected age.</param>
        [TestCase("User1", "Surname1", "Hobby1", 10, 25)]
        [TestCase("User2", "Surname2", "Hobby2", 0, 18)]
        public void Constructor_InitializesProperties(string name, string surname, string hobby, int xp, int age)
        {
            // Act
            var npc = new NPC(name, surname, hobby, xp, age);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(npc.Name, Is.EqualTo(name));
                Assert.That(npc.Surename, Is.EqualTo(surname));
                Assert.That(npc.Hobby, Is.EqualTo(hobby));
                Assert.That(npc.XP, Is.EqualTo(xp));
                Assert.That(npc.Age, Is.EqualTo(age));
            });
        }
    }
}