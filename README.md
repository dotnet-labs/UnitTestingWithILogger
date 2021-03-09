# Unit Testing with .NET Core `ILogger<T>`

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

## [Medium Article](https://codeburst.io/unit-testing-with-net-core-ilogger-t-e8c16c503a80)

Because `ILogger<T>` objects are frequently used in controllers and service classes, we cannot avoid them in unit tests. In this post, we will go over some common ways to work with `ILogger<T>` objects in unit testing.

1. Replace `ILogger<T>` with `NullLogger<T>`
2. Create a Real `ILogger<T>` that Logs to Console
3. Mock an `ILogger<T>` Object

## License

Feel free to use the code in this repository as it is under MIT license.

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>
