CREATE DATABASE communityservice;
USE communityservice;

-- Table to store users including service providers initially registered as users.
CREATE TABLE users (
    userID INT PRIMARY KEY IDENTITY, -- Unique identifier for users
    userName NVARCHAR(50), -- User's name
    userType NVARCHAR(50) NOT NULL CHECK (userType IN ('Service Provider', 'Customer', 'Admin')), -- Type of user
    email NVARCHAR(255) UNIQUE NOT NULL, -- Email address of the user
    userPhoto VARBINARY(MAX), -- User's photo
    password NVARCHAR(255) NOT NULL, -- Password for user authentication
    profileCompleted BIT NOT NULL DEFAULT 0, -- Indicates if the profile is completed (0 for incomplete, 1 for complete)
    twoFactorAuth BIT NOT NULL DEFAULT 0 -- Indicates if two-factor authentication is enabled
); 

-- Table to store additional details for service providers.
CREATE TABLE serviceproviders (
    serviceProviderID INT PRIMARY KEY IDENTITY, -- Unique identifier for service providers
    serviceProviderPhotos VARBINARY(MAX), -- Photos of the service provider
    serviceProviderdescription NVARCHAR(MAX), -- Description of the service provider
    rating DECIMAL(3,2), -- Rating of the service provider
    experienceYears INT, -- Qualifications of the service provider
    minimumNoticeHours INT, -- Minimum notice required for bookings
    registrationStatus NVARCHAR(50) DEFAULT 'Pending' CHECK (registrationStatus IN ('Pending', 'Approved')), -- Status of user registration
    FOREIGN KEY (serviceProviderID) REFERENCES users(userID) -- Foreign key constraint
);

-- Table to store contact details of users.
CREATE TABLE contactDetails (
    contactID INT PRIMARY KEY IDENTITY, -- Unique identifier for contact details
    userID INT UNIQUE, -- Foreign key referencing the corresponding user
    email NVARCHAR(255), -- Email address of the user
    location NVARCHAR(255), -- Location of the user or service provider
    mobileNumber NVARCHAR(10), -- Mobile number of the user
    socialMedia NVARCHAR(MAX), -- Social media accounts of the user
    FOREIGN KEY (userID) REFERENCES users(userID) -- Foreign key constraint
);

-- Table to store bank details of service providers.
CREATE TABLE bankDetailsOfServiceProvider (
    bankDetailID INT PRIMARY KEY IDENTITY, -- Unique identifier for bank details
    serviceProviderID INT UNIQUE, -- Foreign key referencing the corresponding service provider
    accountHolderName NVARCHAR(255), -- Account holder name
    accountNumber NVARCHAR(50), -- Account number
    bankName NVARCHAR(255), -- Bank name
    branchName NVARCHAR(255), -- Branch name
    ifscCode NVARCHAR(20), -- IFSC code
    FOREIGN KEY (serviceProviderID) REFERENCES serviceproviders(serviceProviderID) -- Foreign key constraint
);

-- Table to store service areas.
CREATE TABLE serviceAreas (
    areaID INT PRIMARY KEY IDENTITY, -- Unique identifier for service areas
    area NVARCHAR(255), -- Area where the service provider operates
    location NVARCHAR(255) 
);

create table serviceTypes(
    serviceID INT PRIMARY KEY IDENTITY, -- Unique identifier for serviceTypes
    serviceTypeName NVARCHAR(255), -- name for the service type
);

-- Table to store services provided by service providers.
CREATE TABLE services (
    serviceID INT PRIMARY KEY IDENTITY, -- Unique identifier for services
    serviceProviderID INT, -- Foreign key referencing the corresponding service provider
    serviceTypeID INT, -- Foreign key referencing the corresponding service type
    serviceName NVARCHAR(255), -- Name of the service
    price DECIMAL(10, 2), -- Price of the service
    serviceDescription NVARCHAR(700), -- Description of the service
    completionTime INT, -- Time required to complete the service (in minutes or hours)
    areaID INT, -- Foreign key referencing the corresponding area
    FOREIGN KEY (serviceProviderID) REFERENCES serviceproviders(serviceProviderID), -- Foreign key constraint
    FOREIGN KEY (serviceTypeID) REFERENCES serviceTypes(serviceID), -- Foreign key constraint
    FOREIGN KEY (areaID) REFERENCES serviceAreas(areaID) -- Foreign key constraint
);

-- Table to store work hours of service providers.
CREATE TABLE workHours (
    hourID INT PRIMARY KEY IDENTITY, -- Unique identifier for work hours
    serviceProviderID INT, -- Foreign key referencing the corresponding service provider
    dayOfWeek NVARCHAR(50), -- Day of the week
    startTime TIME, -- Start time of work
    endTime TIME, -- End time of work
    FOREIGN KEY (serviceProviderID) REFERENCES serviceproviders(serviceProviderID) -- Foreign key constraint
);

-- Table to store service area timeslots.
CREATE TABLE serviceAreaTimeslots (
    areaTimeslotID INT PRIMARY KEY IDENTITY, -- Unique identifier for service area timeslots
    serviceProviderID INT, -- Foreign key referencing the corresponding service provider
    startTime TIME, -- Start time of the timeslot
    timeslotDate DATE, -- Date of the timeslot
    FOREIGN KEY (serviceProviderID) REFERENCES serviceproviders(serviceProviderID) -- Foreign key constraint
);

-- Table to store appointments.
CREATE TABLE appointments (
    appointmentID INT PRIMARY KEY IDENTITY, -- Unique identifier for appointments
    serviceProviderID INT, -- Foreign key referencing the corresponding service provider
    customerID INT, -- Foreign key referencing the corresponding customer
    areaTimeslotID INT, -- Foreign key referencing the corresponding service area timeslot
    appointmentStatus NVARCHAR(50) DEFAULT 'Pending' CHECK (appointmentStatus IN ('Pending','Scheduled', 'Completed', 'Cancelled')), -- Status of the appointment
    bookingAdvance DECIMAL(10, 2) DEFAULT 0.0, -- Advance payment amount
    location NVARCHAR(255), -- Location for the appointment
    FOREIGN KEY (serviceProviderID) REFERENCES serviceproviders(serviceProviderID), -- Foreign key constraint
    FOREIGN KEY (customerID) REFERENCES users(userID), -- Foreign key constraint
    FOREIGN KEY (areaTimeslotID) REFERENCES serviceAreaTimeslots(areaTimeslotID) -- Foreign key constraint
);

-- Table to store payments.
CREATE TABLE payments (
    paymentID INT PRIMARY KEY IDENTITY, -- Unique identifier for payments
    appointmentID INT, -- Foreign key referencing the corresponding appointment
    amount DECIMAL(10, 2), -- Amount of the payment
    paymentDateTime DATETIME, -- Date and time of the payment
    paymentType NVARCHAR(50) CHECK (paymentType IN ('Advance', 'Final')), -- Type of payment (Advance or Final)
    paymentStatus NVARCHAR(50) CHECK (paymentStatus IN ('Pending', 'Completed', 'Refunded')), -- Status of the payment
    FOREIGN KEY (appointmentID) REFERENCES appointments(appointmentID) -- Foreign key constraint
);

-- Table to store reviews.
CREATE TABLE reviews (
    reviewID INT PRIMARY KEY IDENTITY, -- Unique identifier for reviews
    appointmentID INT, -- Foreign key referencing the corresponding appointment
    rating DECIMAL(3,2), -- Rating given by the customer
    reviewText NVARCHAR(MAX), -- Text of the review
    reviewDate DATETIME, -- Date of the review
    FOREIGN KEY (appointmentID) REFERENCES appointments(appointmentID) -- Foreign key constraint
);

-- Table to store messages.
CREATE TABLE messages (
    messageID INT PRIMARY KEY IDENTITY, -- Unique identifier for messages
    appointmentID INT, -- Foreign key referencing the corresponding appointment
    senderID INT, -- Foreign key referencing the user who sent the message
    receiverID INT, -- Foreign key referencing the user who received the message
    messageText NVARCHAR(MAX), -- Text of the message
    sentDateTime DATETIME, -- Date and time when the message was sent
    isRead BIT DEFAULT 0, -- Indicates if the message has been read (0 for unread, 1 for read)
    FOREIGN KEY (appointmentID) REFERENCES appointments(appointmentID), -- Foreign key constraint
    FOREIGN KEY (senderID) REFERENCES users(userID), -- Foreign key constraint
    FOREIGN KEY (receiverID) REFERENCES users(userID) -- Foreign key constraint
);

-- Table to store address queries.
CREATE TABLE AddressQueries (
    queryID INT PRIMARY KEY IDENTITY, -- Unique identifier for the query
    userID INT, -- Foreign key referencing the user who submitted the query
    query NVARCHAR(MAX), -- Text of the query
    queryDate DATETIME, -- Date and time when the query was submitted
    status NVARCHAR(50) DEFAULT 'In Process' CHECK (status IN ('In Process', 'Resolved')), -- Status of the query
    resolutionDate DATETIME, -- Date and time when the query was resolved
    FOREIGN KEY (userID) REFERENCES users(userID) -- Foreign key constraint
);

-- Table to store software feedback.
CREATE TABLE SoftwareFeedback (
    feedbackID INT PRIMARY KEY IDENTITY, -- Unique identifier for the feedback
    userID INT, -- Foreign key referencing the user who provided the feedback
    feedbackText NVARCHAR(MAX), -- Text of the feedback
    feedbackDate DATETIME, -- Date and time when the feedback was submitted
    FOREIGN KEY (userID) REFERENCES users(userID) -- Foreign key constraint
);
