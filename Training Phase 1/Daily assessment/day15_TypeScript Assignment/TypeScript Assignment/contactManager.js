// Contact Manager Class
class ContactManager {
    constructor() {
        this.contacts = [];
    }
    // Add a new contact
    addContact(contact) {
        this.contacts.push(contact);
        console.log(`Contact added successfully: ${contact.name}`);
    }
    // View all contacts
    viewContacts() {
        console.log("Contact List:");
        if (this.contacts.length === 0) {
            console.log("No contacts available.");
        }
        else {
            console.table(this.contacts);
        }
    }
    // Modify an existing contact
    modifyContact(id, updatedContact) {
        const contact = this.contacts.find(c => c.id === id);
        if (contact) {
            Object.assign(contact, updatedContact);
            console.log(`Contact with ID ${id} updated successfully.`);
        }
        else {
            console.log(`Error: Contact with ID ${id} not found.`);
        }
    }
    // Delete a contact
    deleteContact(id) {
        const index = this.contacts.findIndex(c => c.id === id);
        if (index !== -1) {
            this.contacts.splice(index, 1);
            console.log(`Contact with ID ${id} deleted successfully.`);
        }
        else {
            console.log(`Error: Contact with ID ${id} not found.`);
        }
    }
}
// Test the ContactManager class
const manager = new ContactManager();
manager.addContact({ id: 1, name: "Alice", email: "alice@example.com", phone: "123-456-7890" });
manager.addContact({ id: 2, name: "Bob", email: "bob@example.com", phone: "987-654-3210" });
manager.viewContacts();
manager.modifyContact(1, { phone: "111-222-3333" });
manager.viewContacts();
manager.deleteContact(2);
manager.viewContacts();
manager.deleteContact(3); // Trying to delete a non-existent contact
