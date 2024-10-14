
# Custom Healthcare Data Mapper

This project demonstrates my capability as a data analyst to efficiently manage and map healthcare data using custom mappings based on LOINC codes. The code provided automates the conversion of raw healthcare data into a standardized format that can be used for analysis and reporting, specifically within the healthcare sector.

## Overview

In this project, I have created a data mapper that takes in a CSV file containing healthcare data (including patient information and lab results) and converts it into a standardized format using LOINC codes. LOINC codes (Logical Observation Identifiers Names and Codes) are used to universally identify laboratory and clinical observations. By using a dictionary-based mapping system, I ensure that the raw data is accurately converted to its LOINC equivalents, enabling efficient healthcare data exchange, reporting, and analysis.

## Features

- **LOINC Mapping**: The script uses a dictionary to map specific lab tests (like cholesterol, glucose, etc.) to their corresponding LOINC codes, ensuring data is standardized.
- **CSV Data Processing**: It reads a CSV file containing patient data and medical test results, processes each entry, and outputs a new CSV with standardized LOINC codes.
- **Data Accuracy**: Only non-empty results are written to the final output file, ensuring that the data is clean and relevant.
- **Scalable**: Easily extendable to add more tests and map additional LOINC codes as needed.

## How It Works

1. The program initializes a dictionary (`loinc`) where specific medical tests (e.g., "hdl cholesterol", "triglycerides") are mapped to their respective LOINC codes.
2. It reads a CSV file containing raw healthcare data (e.g., patient names, test results) from the file system.
3. For each row in the CSV file, it creates a list of LOINC entries. Each entry corresponds to a specific lab test and includes the test result and its LOINC code.
4. The script writes each valid LOINC entry to a new CSV file, ensuring that only rows with actual results are saved.

## Usage

### Prerequisites

- .NET framework
- Basic understanding of CSV file formats and LOINC codes

### How to Run

1. Place your raw healthcare data file (`LastEdition.csv`) in the specified directory.
2. Open the project in a .NET-capable IDE or run it from the terminal.
3. The program reads from `LastEdition.csv` and writes the mapped data to `LastEdition_MAPPED.csv`.

### Example

A sample of the dictionary used to map test names to LOINC codes:

```csharp
loinc.Add("hdl cholesterol", "2085-9");
loinc.Add("triglycerides", "2571-8");
loinc.Add("glucose", "1558-6");
```

After processing, the output CSV will contain data similar to this:

```
FirstName, LastName, SSN, Location, LOINC Code, Test Result, etc.
John, Doe, 123-45-6789, Boston, 2085-9, 60
```

## Customization

If you need to add more lab tests and map them to LOINC codes, simply modify the dictionary in the `Main()` method:

```csharp
loinc.Add("new test", "new-loinc-code");
```

## Why This Matters

Standardizing healthcare data is crucial for interoperability, data analysis, and patient care. With my skills as a data analyst, I can help organizations efficiently convert and manage their healthcare data, ensuring accuracy and consistency. By creating a custom mapper for this purpose, I demonstrate my understanding of both technical requirements and the needs of the healthcare sector.

## Future Work

- Integrating additional healthcare tests and LOINC codes.
- Enhancing error handling for missing or incomplete data.
- Adding support for more data formats (e.g., JSON or XML).

## Contact

For any questions or further collaboration, feel free to reach out via [Your Contact Information].
