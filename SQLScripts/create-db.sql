CREATE DATABASE [ProductManagementDB];
IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'ProductManagementDB')
BEGIN
    CREATE DATABASE [ProductManagementDB];
END;