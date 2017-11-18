CREATE PROCEDURE spCreateAddress
    @Id UNIQUEIDENTIFIER,
	@CustomerId UNIQUEIDENTIFIER,
	@Number VARCHAR(10),
	@Complement VARCHAR(40),
	@District VARCHAR(60),
	@City VARCHAR(60),
	@State CHAR(2),
	@Country CHAR(2),
	@ZipCode CHAR(8),
	@Type INT
AS
    INSERT INTO [Address] (
        [Id],
        [CustomerId],
        [Number],
        [Complement],
        [District],
        [City],
        [State],
        [Country],
        [ZipCode],
        [Type]
    ) VALUES (
        @Id,
        @CustomerId,
        @Number,
        @Complement,
        @District,
        @City,
        @State,
        @Country,
        @ZipCode,
        @Type
    )