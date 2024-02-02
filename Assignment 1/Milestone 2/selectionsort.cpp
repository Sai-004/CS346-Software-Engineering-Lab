#include <iostream>
#include <limits>
#include <sstream>
#include <cctype>
using namespace std;

// Function to perform selection sort on an array
void selectionSort(int arr[], int n) {
    for (int i = 0; i < n - 1; ++i) {
        // Assume the current index is the minimum
        int minIndex = i;

        // Find the minimum element in the unsorted part of the array
        for (int j = i + 1; j < n; ++j) {
            if (arr[j] < arr[minIndex]) {
                minIndex = j;
            }
        }

        // Swap the found minimum element with the first element
        swap(arr[i], arr[minIndex]);

        // Print the array after each iteration
        cout << "After iteration " << i + 1 << ": ";
        for (int k = 0; k < n; ++k) {
            cout << arr[k] << " ";
        }
        cout << endl;
    }
}

// Function to check if the input string contains special characters
bool hasSpecialChars(const string& input) {
    for (char ch : input) {
        if (!isalnum(ch)) {
            return true;
        }
    }
    return false;
}

// Function to check if the input string is a mixed-type input
bool isMixedType(const string& input) {
    bool hasDigit = false;
    bool hasLetter = false;

    for (char ch : input) {
        if (isdigit(ch)) {
            hasDigit = true;
        } else if (isalpha(ch)) {
            hasLetter = true;
        }
    }

    return hasDigit && hasLetter;
}

// Function to check if the input string contains non-integer characters
bool hasNonInteger(const string& input) {
    for (char ch : input) {
        if (!isdigit(ch)) {
            return true;
        }
    }
    return false;
}

int main() {
    const int maxSize = 15;
    int arr[maxSize];
    int n;

    // Input array elements
    cout << "Enter the number of elements (max " << maxSize << "): ";
    cin >> n;

    // Validate input size
    if (n > maxSize || n <= 0) {
        cout << "Invalid array size. Exiting.\n";
        return 1;
    }

    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear the buffer

    cout << "Enter array elements between -99 and 100:\n";

    for (int i = 0; i < n; ++i) {
        cout << "Element " << i + 1 << ": ";

        string input;
        getline(cin, input);

        // Check for invalid types
        if (input.empty() || hasSpecialChars(input) || isMixedType(input) || hasNonInteger(input)) {
            cout << "Invalid input. Please enter valid integers between -99 and 100.\n";
            return 1;
        }

        // Convert the valid input string to an integer
        stringstream ss(input);
        ss >> arr[i];

        // Check if the entered element is within the valid range
        if (arr[i] < -99 || arr[i] > 100) {
            cout << "Invalid input. Please enter numbers between -99 and 100.\n";
            return 1;
        }
    }

    cout << "Original Array: ";
    for (int i = 0; i < n; ++i) {
        cout << arr[i] << " ";
    }
    cout << endl;

    // Perform selection sort
    selectionSort(arr, n);

    cout << "Sorted Array: ";
    for (int i = 0; i < n; ++i) {
        cout << arr[i] << " ";
    }
    cout << endl;

    return 0;
}
