# Factory Pattern
Basic example of how to use this pattern

## Different types of properties
- Property (base)
- Apartment : Property
- Hotel : Property
- House : Property

### Property class
Common props:

- Address
- Type
- UsefulArea
- Bedrooms
- Bathrooms
- Year
- IsForSale

### Inheritance classes
Custom props for Apartment:

- CondominiumFees
- Floor

Custom props for Hotel:

- HasPool
- PetFriendly

### Factories
- PropertyFactory (base)
	- GetProperty method
- ApartmentFactory : PropertyFactory
- HotelFactory : PropertyFactory
- HouseFactory : PropertyFactory
