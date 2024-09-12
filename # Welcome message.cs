# Welcome message
print("Welcome to Package Express. Please follow the instructions below.")

# Prompt for the package weight
weight = float(input("Please enter the package weight: "))

# Check if the package is too heavy
if weight > 50:
    print("Package too heavy to be shipped via Package Express. Have a good day.")
else:
    # Prompt for the package dimensions: width, height, and length
    width = float(input("Please enter the package width: "))
    height = float(input("Please enter the package height: "))
    length = float(input("Please enter the package length: "))

    # Check if the sum of dimensions exceeds the limit
    if width + height + length > 50:
        print("Package too big to be shipped via Package Express.")
    else:
        # Calculate the shipping quote based on the formula (width * height * length * weight) / 100
        total = (width * height * length * weight) / 100
        # Display the calculated quote as a dollar amount
        print(f"Your estimated total for shipping this package is: ${total:.2f}")
        print("Thank you!")
