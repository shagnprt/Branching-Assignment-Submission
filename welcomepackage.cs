# Start of the Package Express Shipping Program

# Display a welcome message to the user
print("Welcome to Package Express. Please follow the instructions.")

#  Begin input and validation for package weight

# Loop to ensure the user provides valid input for weight
while True:
    try:
        # Prompt the user for the package weight and convert it to a floating-point number
        weight = float(input("Please enter the package weight (in lbs): "))
        
        # Check if the weight is greater than zero
        if weight <= 0:
            # If invalid weight, prompt the user again
            print("Invalid input. Weight must be a positive number.")
            continue
        break
    except ValueError:
        # Handle non-numeric input
        print("Invalid input. Please enter a valid number for the weight.")

# Check if the weight exceeds the allowed limit of 50 lbs
if weight > 50:
    # If the weight is too high, display an error message and end the program
    print("Package too heavy to be shipped via Package Express. Have a good day.")
else:
    # Proceed to collect dimensions (width, height, and length)
    
    # Input and validation for package width
    
    while True:
        try:
            # Prompt the user for the package width
            width = float(input("Please enter the package width (in inches): "))
            
            # Ensure the width is a positive number
            if width <= 0:
                print("Invalid input. Width must be a positive number.")
                continue
            break
        except ValueError:
            # Handle non-numeric input
            print("Invalid input. Please enter a valid number for the width.")
    
    # Input and validation for package height
    
    while True:
        try:
            # Prompt the user for the package height
            height = float(input("Please enter the package height (in inches): "))
            
            # Ensure the height is a positive number
            if height <= 0:
                print("Invalid input. Height must be a positive number.")
                continue
            break
        except ValueError:
            # Handle non-numeric input
            print("Invalid input. Please enter a valid number for the height.")
    
    # Input and validation for package length
    
    while True:
        try:
            # Prompt the user for the package length
            length = float(input("Please enter the package length (in inches): "))
            
            # Ensure the length is a positive number
            if length <= 0:
                print("Invalid input. Length must be a positive number.")
                continue
            break
        except ValueError:
            # Handle non-numeric input
            print("Invalid input. Please enter a valid number for the length.")
    
    # Calculate the total dimensions (width + height + length)
    
    total_dimensions = width + height + length
    
    # Check if the total dimensions exceed the limit of 50 inches
    if total_dimensions > 50:
        # If the total dimensions exceed 50, display an error message and terminate the program
        print("Package too big to be shipped via Package Express.")
    else:
        # Calculate the volume of the package
        # Volume is calculated as width * height * length
        volume = width * height * length
        
        # Calculate the shipping quote
        # The formula for shipping quote is (volume * weight) / 100
        quote = (volume * weight) / 100
        
        # Display the shipping quote
        # The result is formatted to two decimal places to reflect a dollar amount
        print(f"Your estimated total for shipping this package is: ${quote:.2f}")
        
        # Thank the user for using Package Express
        print("Thank you for using Package Express!")
