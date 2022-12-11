namespace TheAreaOfFiguresLibrary.UnitTests
{
    
    public class TriangleTests
    {
        [Fact]
        public void IsTheTriangleRectangular_NotRectangular_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle(2, 3, 4);

            //Act
            var result = triangle.IsTheTriangleRectangular();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsTheTriangleRectangular_Rectangular_ReturnTrue()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var result = triangle.IsTheTriangleRectangular();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Square_3and4and5_Return6()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;

            //Act
            var result = triangle.Square();

            //Assert
            Assert.Equal(expected, result);
        }
    }

   
    public class CircleTest
    {
        [Fact]
        public void Square_10_Return314_2()
        {
            //Arrange
            var circle = new Circle(10);
            double expected = 314.2;

            //Act
            var result = circle.Square();

            //Assert
            Assert.Equal(expected, result);
        }
    }


}